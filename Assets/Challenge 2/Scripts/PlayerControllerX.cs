using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 1.0f;
    private float waitTime = 1.0f;

    // Update is called once per frame
    void Update()
    {   //Check if time has gotten beyond wait time
        if (timer < waitTime)
        {
            // If time is shorter, do nothing 
        }
        // On spacebar press, send dog if time is greater than wait time
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            //Call dog spawn method
            spawnDog();
            // Reset Timer to 0
            timer = 0;
        }

        // Run timer each frame
        timer += Time.deltaTime;
   }

    //Dog spawn method
   void spawnDog ()
   {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
   }
}
