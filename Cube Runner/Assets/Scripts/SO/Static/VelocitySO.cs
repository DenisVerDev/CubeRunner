using UnityEngine;

[CreateAssetMenu(fileName = nameof(VelocitySO), menuName = "StaticSO/" + nameof(VelocitySO))]
public class VelocitySO : StaticSO<float>
{
    public override float Value => baseValue * Time.deltaTime;
}
