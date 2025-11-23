using UnityEngine;

public class MoveForawrd : MonoBehaviour
{
    public float speed = 10.0f;
    private PlayerController playerControllerScript;

    void Start()
    {
       playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        // GameOver Trigger
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
