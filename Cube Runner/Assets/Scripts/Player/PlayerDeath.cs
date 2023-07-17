using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public float restartDelay;

    [SerializeField]
    private FlagSO playerDeathEvent;

    [SerializeField]
    private SceneSO restartScene;

#if UNITY_EDITOR
    void Start() => playerDeathEvent.value = false;
#endif
    void LateUpdate()
    {
        if (playerDeathEvent.value)
            Invoke(nameof(RestartPlayground), restartDelay);
    }

    void RestartPlayground() => restartScene.LoadScene();
}
