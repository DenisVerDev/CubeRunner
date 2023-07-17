using UnityEngine;

[CreateAssetMenu(fileName = nameof(VelocitySO), menuName = "SO/" + nameof(VelocitySO))]
public class VelocitySO : ScriptableObject
{
    public float Value
    {
        get { return velocity * Time.deltaTime; }
        set { velocity = value < 0 ? 0 : value; }
    }

    private float velocity;
}
