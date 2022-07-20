using UnityEngine;

public class pipe_spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipes;
    public float height;
    public float dieTime = 6;
    
    // Update is called once per frame
    void Update()
    {
        generateNormalPipe();
    }

    public void generateNormalPipe()
    {
        bool ShouldGenerateHardPipe = Score.score % 23 == 0 && Score.score != 0;
        bool ShouldGenerateTrollPipe = Score.score % 17 == 0 && Score.score != 0;
        if (!ShouldGenerateHardPipe && !ShouldGenerateTrollPipe)
        {
            if (timer > maxTime)
            {
                GameObject newpipes = Instantiate(pipes);
                newpipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newpipes, dieTime);
                timer = 0;
            }

            timer += Time.deltaTime;
        }
        else
        {
            Debug.Log("Not generating normal pipe");
        }
    }
}
