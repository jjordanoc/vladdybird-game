using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverHandler : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("VladdyBird Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }
}
