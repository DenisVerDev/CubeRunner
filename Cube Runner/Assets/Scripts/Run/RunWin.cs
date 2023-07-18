using UnityEngine;

public class RunWin : MonoBehaviour
{
    [SerializeField]
    private GameObject winningMenue;

    [SerializeField]
    private DynamicInt32SO currentStage;

    [SerializeField]
    private Int32SO maxStages;

    void LateUpdate()
    {
        if(currentStage.Value >= maxStages.Value)
        {
            winningMenue.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
