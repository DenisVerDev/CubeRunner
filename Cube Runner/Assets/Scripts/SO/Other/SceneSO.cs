using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = nameof(SceneSO), menuName = "OtherSO/" + nameof(SceneSO))]
public class SceneSO : ScriptableObject
{
    [SerializeField]
    private string sceneName;

    public void LoadScene() => SceneManager.LoadScene(sceneName);

    public void Quit() => Application.Quit();
}
