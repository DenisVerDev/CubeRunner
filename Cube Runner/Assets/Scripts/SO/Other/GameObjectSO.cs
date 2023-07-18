using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameObjectSO), menuName = "OtherSO/" + nameof(GameObjectSO))]
public class GameObjectSO : ScriptableObject
{
    public GameObject gameObject;
}
