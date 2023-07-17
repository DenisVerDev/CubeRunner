using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = nameof(SceneSO), menuName = "SO/" + nameof(SceneSO))]
public class SceneSO : ScriptableObject
{
    [SerializeField]
    private string sceneName;

    public void LoadScene() => SceneManager.LoadScene(sceneName);
}
