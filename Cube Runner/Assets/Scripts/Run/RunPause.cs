using UnityEngine;

public class RunPause : MonoBehaviour
{
    public GameObject pauseMenue;

    [SerializeField]
    private FlagSO runPausedStatus;

    void Start()
    {
        runPausedStatus.value = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            runPausedStatus.value = !runPausedStatus.value;
            pauseMenue.SetActive(runPausedStatus.value);

            Time.timeScale = runPausedStatus.value ? 0 : 1;
        }
    }
}
