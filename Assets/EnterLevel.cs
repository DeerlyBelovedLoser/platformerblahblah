using UnityEngine;
using UnityEngine.SceneManagement;

public class enterLevelOne : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
