using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FadeEffect : MonoBehaviour
{
    private SpriteRenderer _sprite;
    private bool _isFadeBegin;
    private float _alphaValue = 1.0f;
    private float _timerDelay;
    
    [SerializeField] private float delayBeforeFade = 1;
    [SerializeField] private float fadeTime = 1;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    public void Fade()
    {
        _isFadeBegin = true;
    }

    private void Update()
    {
        if (!_isFadeBegin) return;

        _timerDelay += Time.deltaTime;
        if (_timerDelay >= delayBeforeFade)
        {
            if (_alphaValue > 0)
            {
                float fadeSpeed = 1.0f / fadeTime * Time.deltaTime;
                _alphaValue -= fadeSpeed;
                _sprite.color = new Color(1f, 1f, 1f, _alphaValue);
            }

            if (_alphaValue <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
