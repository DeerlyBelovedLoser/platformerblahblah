using UnityEngine;
using UnityEngine.SceneManagement; 

public class restartScene : MonoBehaviour
{
    public void resetScene()
    {
        // Reloads the scene currently active
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        // Optional: Ensure time scale is reset if your game was paused
        Time.timeScale = 1f; 
    }
}
