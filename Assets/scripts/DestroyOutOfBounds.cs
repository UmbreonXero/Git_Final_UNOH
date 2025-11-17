using UnityEngine;

public class MoveTrafficLeft : MonoBehaviour
{
    public float bottomBound = -30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
