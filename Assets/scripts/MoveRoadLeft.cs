using UnityEngine;
using UnityEngine.Rendering;

public class MoveRoadLeft : MonoBehaviour
{
    private float speed = 30.0f;
    private float rightBound = 10;
    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        
    }
}
