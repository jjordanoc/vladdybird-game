using UnityEngine;

public class hardPipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject HardPipes;
    public float height;
    public float dieTime = 6;

    // Update is called once per frame
    void Update()
    {
        generateHardPipe();
    }

    public void generateHardPipe()
    {
        bool ShouldGenerateHardPipe = Score.score % 23 == 0 && Score.score != 0;
        if (ShouldGenerateHardPipe)
        {
            Debug.Log("Generating hard pipe");

            if (timer > maxTime)
            {
                GameObject newHardPipes = Instantiate(HardPipes);
                newHardPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newHardPipes, dieTime);
                timer = 0;
            }

            timer += Time.deltaTime;
        }
    }
}
