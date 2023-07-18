using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    private float restartDelay;

    [SerializeField]
    private DynamicFlagSO playerDeathEvent;

    [SerializeField]
    private SceneSO restartScene;

    void LateUpdate()
    {
        if (playerDeathEvent.Value)
            Invoke(nameof(RestartPlayground), restartDelay);
    }

    void RestartPlayground() => restartScene.LoadScene();
}
