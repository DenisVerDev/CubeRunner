using System.Collections.Generic;
using UnityEngine;

public class RunConfigure : MonoBehaviour
{
    [SerializeField]
    private List<DynamicFlagSO> dynamicFlags = new List<DynamicFlagSO>();

    [SerializeField]
    private List<DynamicInt32SO> dynamicInt32s = new List<DynamicInt32SO>();

    [SerializeField]
    private List<DynamicVelocitySO> dynamicVelocities = new List<DynamicVelocitySO>();

    private void Awake()
    {
        dynamicFlags.ForEach(x => x.Value = x.BaseValue);
        dynamicInt32s.ForEach(x => x.Value = x.BaseValue);
        dynamicVelocities.ForEach(x => x.Value = x.BaseValue);
    }
}