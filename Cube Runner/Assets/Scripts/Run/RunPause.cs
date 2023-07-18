using UnityEngine;

public class RunPause : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenue;

    [SerializeField]
    private DynamicFlagSO runPausedStatus;

    void Start() => Time.timeScale = 1f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            runPausedStatus.Value = !runPausedStatus.Value;
            pauseMenue.SetActive(runPausedStatus.Value);

            Time.timeScale = runPausedStatus.Value ? 0 : 1;
        }
    }
}
