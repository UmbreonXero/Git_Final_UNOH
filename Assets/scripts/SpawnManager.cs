using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] trafficPrefab;
    public int trafficIndex;
    private float startDelay = 2;
    private float spawnInterval = 0.5f;
    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnTraffic", startDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void SpawnTraffic()
    { if (playerControllerScript.gameOver == false)
        {
        int trafficIndex = Random.Range(0, trafficPrefab.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-10, 10), 0, 110);
        Instantiate(trafficPrefab[trafficIndex], spawnpos, trafficPrefab[trafficIndex].transform.rotation);
        }
    }
}
