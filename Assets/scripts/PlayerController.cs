using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 10;
    public bool gameOver = false;
    public bool hitCar;
    private float health = 100.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        //Keep player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Traffic"))
        {
            health -= 2.0f;
            Debug.Log("Player Health: " + health);
            if (health <= 0)
            {
                Debug.Log("Game Over!");
                gameOver = true;
            }
        }
    }

    private void OnCollisionEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Traffic"))
        {
            hitCar = true;
        }
    }
}

