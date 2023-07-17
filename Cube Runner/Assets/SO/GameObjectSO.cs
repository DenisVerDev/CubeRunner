using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameObjectSO), menuName = "SO/" + nameof(GameObjectSO))]
public class GameObjectSO : ScriptableObject
{
    public GameObject gameObject;
}
