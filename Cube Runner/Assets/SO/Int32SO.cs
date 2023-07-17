using UnityEngine;

[CreateAssetMenu(fileName = nameof(Int32SO),menuName = "SO/"+nameof(Int32SO))]
public class Int32SO : ScriptableObject
{
    public int value;
}
