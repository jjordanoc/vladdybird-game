using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameScoreCanvas;

    private void Start()
    {
        Debug.Log("Game start!");
        Time.timeScale = 1;
        int seed = Random.Range(0, 2);
        if(seed == 0)
        {
            GameObject.FindGameObjectWithTag("Lenin").SetActive(false);
            Debug.Log("Stalin chosen");
        }
        else
        {
            GameObject.FindGameObjectWithTag("Stalin").SetActive(false);
            Debug.Log("Lenin chosen");
        }
        gameScoreCanvas.SetActive(true);
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
        SceneManager.UnloadScene("GameOver");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
        SceneManager.UnloadScene("Intro");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
        SceneManager.UnloadScene("VladdyBird Game");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos

    }

    public void GameOver()
    {
        Debug.Log("Game over!");  
        gameScoreCanvas.SetActive(false);
        SceneManager.LoadScene("GameOver");
    }

}
