using UnityEngine;

public class DynamicSO<T> : StaticSO<T>
{
    [SerializeField]
    protected T dynamicValue;

    public virtual new T Value
    {
        get => dynamicValue;
        set => dynamicValue = value;
    }

    public T BaseValue => base.Value;

    public void SetToBase() => dynamicValue = baseValue;
}
