using UnityEngine;

public class LagManager : MonoBehaviour
{
    public GameObject text;
    public float dieTime;

    // Update is called once per frame
    void Update()
    {
        Destroy(text, dieTime);
    }
}
