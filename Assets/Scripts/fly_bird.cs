using UnityEngine;
using UnityEngine.Advertisements;

public class fly_bird : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    public string gameID = "3541042";
    public bool testMode = true;

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID, testMode);
        /*
        if (Advertisement.IsReady("banner"))
        {
            Debug.Log("Showing banner");
            Advertisement.Show("banner");
            Debug.Log("Should've shown banner");
        }
        */
        rb = GetComponent<Rigidbody2D>();
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

    //Plays when the bird touches the pipes or the ground (dies)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int random = Random.Range(0, 9);
        Debug.Log("Random = " + random);
        
        //Sound effect of dying
        FindObjectOfType<AudioManager>().Play("Hit");

        if(Score.score >= 5 && Score.score < 10)
        {
            if(random == 2)
            {
                if (Advertisement.IsReady("video"))
                {
                    Debug.Log("Showing video ad");
                    Advertisement.Show("video");
                }
            }
        }

        if(Score.score >= 10 && Score.score < 20)
        {
            if(random == 1 || random == 2)
            {
                if (Advertisement.IsReady("video"))
                {
                    Debug.Log("Showing video ad");
                    Advertisement.Show("video");
                }
            }
        }

        if(Score.score >= 20 && Score.score < 50)
        {
            if (random == 1 || random == 2 || random == 3)
            {
                if (Advertisement.IsReady("video"))
                {
                    Debug.Log("Showing video ad");
                    Advertisement.Show("video");
                }
            }
        }

        if(Score.score >= 50)
        {
            if (random == 1 || random == 2 || random == 3 || random == 4)
            {
                if (Advertisement.IsReady("video"))
                {
                    Debug.Log("Showing video ad");
                    Advertisement.Show("video");
                }
            }
        }

        //Calls gamemanager function gameover
        gameManager.GameOver();
        
    }
}
