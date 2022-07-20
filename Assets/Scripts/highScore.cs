using UnityEngine;

public class highScore : MonoBehaviour
{
    public static int high_score;
    // Start is called before the first frame update
    void Start()
    {
        high_score = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score > high_score)
        {
            high_score = Score.score;

            PlayerPrefs.SetInt("HighScore", high_score);
        }
        GetComponent<TMPro.TextMeshProUGUI>().text = high_score.ToString();
    }
}
