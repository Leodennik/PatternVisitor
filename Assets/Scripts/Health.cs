using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int value = 100;
    private int _maxValue;

    private void Start()
    {
        _maxValue = value;
    }

    public void AddValue(int amount)
    {
        SetValue(value + amount);
    }

    public void SetValue(int amount)
    {
        value = Mathf.Clamp(amount, 0, _maxValue);
    }
    
    public int GetValue()
    {
        return value;
    }
}
