using UnityEngine;

public class trollPipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject TrollPipes;
    public float height;
    public float dieTime = 6;

    // Update is called once per frame
    void Update()
    {
        generateTrollPipe();
    }

    public void generateTrollPipe()
    {
        bool ShouldGenerateTrollPipe = Score.score % 17 == 0 && Score.score != 0;
        if (ShouldGenerateTrollPipe)
        {
            Debug.Log("Generating troll pipe");

            if (timer > maxTime)
            {
                GameObject newTrollPipes = Instantiate(TrollPipes);
                newTrollPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newTrollPipes, dieTime);
                timer = 0;
            }

            timer += Time.deltaTime;
        }
    }
}
