using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField]
    private Int32SO playerScore;

    private TMP_Text scoreText;

    void Start() => scoreText = GetComponent<TMP_Text>();
    void LateUpdate() => scoreText.text = playerScore.value.ToString();
}
