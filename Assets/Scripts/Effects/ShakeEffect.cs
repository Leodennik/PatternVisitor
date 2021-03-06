using UnityEngine;
using System.Collections;
 
public class ShakeEffect : MonoBehaviour
{
    [Header("Info")]
    private Vector2 _startPos;
    private float _timer;
    private Vector2 _randomPos;
 
    [Header("Settings")]
    [Range(0f, 2f)]
    [SerializeField] private float time = 0.2f;
    [Range(0f, 5f)]
    [SerializeField] private float distance = 0.1f;
    [Range(0f, 0.1f)]
    [SerializeField] private float delayBetweenShakes = 0f;
 
    private void OnValidate()
    {
        if (delayBetweenShakes > time)
        {
            delayBetweenShakes = time;
        }

        _startPos = transform.position;
    }
 
    public void Begin()
    {
        StopAllCoroutines();
        StartCoroutine(Shake());
    }
 
    private IEnumerator Shake()
    {
        _timer = 0f;
 
        while (_timer < time)
        {
            _timer += Time.deltaTime;
            _randomPos = _startPos + (Random.insideUnitCircle * distance) * Time.timeScale;
            transform.position = _randomPos;
 
            if (delayBetweenShakes > 0f)
            {
                yield return new WaitForSeconds(delayBetweenShakes);
            }
            else
            {
                yield return null;
            }
        }
 
        transform.position = _startPos;
    }
 
}