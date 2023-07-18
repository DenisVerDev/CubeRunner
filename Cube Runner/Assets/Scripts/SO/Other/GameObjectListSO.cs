using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameObjectListSO), menuName = "OtherSO/" + nameof(GameObjectListSO))]
public class GameObjectListSO : ScriptableObject
{
    public List<GameObject> list = new List<GameObject>();
}
