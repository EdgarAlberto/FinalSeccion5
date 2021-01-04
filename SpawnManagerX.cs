using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private int ball ;
 
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, nextWaitTime);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        //generar Random ball 
        ball = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ball], spawnPos, ballPrefabs[ball].transform.rotation);
    }


    private float counter = 0f;
    private float nextWaitTime = 5f;
    void Update()
    {
        counter += Time.deltaTime;
        if(counter>=nextWaitTime)
        {
            //Generamos nueva oleada =nueva bola
            Debug.LogFormat("Hemos esperado {0} segundos", nextWaitTime);
            counter = 0;
            nextWaitTime = Random.Range(2, 5);
        }
    }

}
