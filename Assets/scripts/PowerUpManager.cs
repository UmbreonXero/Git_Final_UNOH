using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject[ ] powerupPrefab;
    public int powerupIndex;
    private float startDelay = 8;
    private float spawnInterval = 5.0f;
    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPowerup", startDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPowerup()
    {if (playerControllerScript.gameOver == false)
        {
        int powerupIndex = Random.Range(0, powerupPrefab.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-10, 10), 1, 110);
        Instantiate(powerupPrefab[powerupIndex], spawnpos, powerupPrefab[powerupIndex].transform.rotation);
        }
    }
}