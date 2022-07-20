using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        //Sound effect of score
        FindObjectOfType<AudioManager>().Play("Coin");
        Debug.Log("Score = " + Score.score);
    }
}
