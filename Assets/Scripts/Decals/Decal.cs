using UnityEngine;

[RequireComponent(typeof(FadeEffect))]
public class Decal : MonoBehaviour
{
    private FadeEffect _fade;

    private void Awake()
    {
        _fade = GetComponent<FadeEffect>();
    }

    private void Start()
    {
        _fade.Fade();
    }
}
