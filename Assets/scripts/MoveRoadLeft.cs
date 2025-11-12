using UnityEngine;
using UnityEngine.Rendering;

public class MoveRoadLeft : MonoBehaviour
{
    private float speed = 30;
    private float rightBound = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
