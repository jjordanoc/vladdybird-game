using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("PlayButton pressed");

        if(PlayerPrefs.GetInt("Tutorial") == 0)
        {
            Debug.Log("Playing tutorial");
            SceneManager.LoadScene("Intro");
        }
        else
        {
        SceneManager.LoadScene("VladdyBird Game");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }

    public void ResetPrefs()
    {
        Debug.Log("Deleting all prefs");
        PlayerPrefs.DeleteAll();
    }
}
