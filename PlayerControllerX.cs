using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float maxTimeDog=1;
    public float counter=1;


    // Update is called once per frame
    void Update()
    {

        counter += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& counter>=maxTimeDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            counter = 0;
        }
        
    }
}
