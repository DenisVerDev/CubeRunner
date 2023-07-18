using UnityEngine;

[CreateAssetMenu(fileName = nameof(DynamicVelocitySO), menuName = "DynamicSO/" + nameof(DynamicVelocitySO))]
public class DynamicVelocitySO : DynamicSO<float>
{
    public override float Value 
    { 
        get => dynamicValue * Time.deltaTime;
        set => dynamicValue = value < 0 ? 0 : value;
    }
}
