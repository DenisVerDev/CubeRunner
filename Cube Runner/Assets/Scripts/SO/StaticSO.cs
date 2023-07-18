using UnityEngine;

public class StaticSO<T> : ScriptableObject
{
    [SerializeField]
    protected T baseValue;

    public virtual T Value => baseValue;
}
