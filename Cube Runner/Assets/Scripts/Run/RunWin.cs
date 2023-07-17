using UnityEngine;

public class RunWin : MonoBehaviour
{
    public GameObject winningMenue;

    [SerializeField]
    private Int32SO currentStage;

    [SerializeField]
    private Int32SO maxStages;

    void LateUpdate()
    {
        if(currentStage.value >= maxStages.value)
        {
            winningMenue.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
