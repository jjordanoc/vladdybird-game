using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    public GameObject instance;
    public float dieTime = 5;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        Destroy(instance, dieTime);
    }
}
