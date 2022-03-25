using UnityEngine;

public sealed class Decals : MonoBehaviour
{
    public static Decals Instance;
    public Decal hole;

    private void Awake()
    {
        Instance = this;
    }
}