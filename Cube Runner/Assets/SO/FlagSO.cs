using UnityEngine;

[CreateAssetMenu(fileName = nameof(FlagSO), menuName = "SO/" + nameof(FlagSO))]
public class FlagSO : ScriptableObject
{
    public bool value;
}
