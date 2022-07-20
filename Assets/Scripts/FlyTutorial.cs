using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyTutorial : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerPrefs.GetInt("Tutorial");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Jump
            rb.velocity = Vector2.up * velocity;
            //Play flap
            FindObjectOfType<AudioManager>().Play("Flap");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<AudioManager>().Play("Hit");
        
        SceneManager.LoadScene("Intro");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Tutorial finished");

        PlayerPrefs.SetInt("Tutorial", 1);

        SceneManager.LoadScene("VladdyBird Game");
    }
}
