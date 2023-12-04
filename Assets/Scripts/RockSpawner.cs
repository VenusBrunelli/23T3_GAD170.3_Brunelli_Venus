using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    //We want to spaw a rock in a random spaw point when the trigger is activated

    //Need a referance to the game object (ROCK)
    //this is a variable
    [SerializeField] private GameObject fallingRockPrefab;

//Need a location (i.e reference to the spawn points)
    [SerializeField] private List<GameObject> rockSpawnPoints = new List<GameObject>();
    [SerializeField] private List<Rock> rocks = new List<Rock>();


    //Need a referance to the collision of the player
    //Week 6 in the slides: lists
    private void OnTriggerEnter(Collider other)
    {
        //if the player activated the trigger
        if (other.CompareTag("Player") == true)
        {
            Debug.Log("cololision aaaa");

            //spawn a falling rock to a random spawn point
            Vector3 spawnPosition = rockSpawnPoints[Random.Range(0, rockSpawnPoints.Count)].transform.position;

            //CHECK THAT THE VARIABLE IS NOT NULL
            if(fallingRockPrefab != null)
            { 
               GameObject newRock = Instantiate(fallingRockPrefab, spawnPosition, Quaternion.identity);

               rocks.Add(newRock.GetComponent<Rock>());
               foreach(Rock rock in rocks)
               {
                rock.name = "BE CAREFUL, ROCKS!!";
                
               }


            }

           

            
        }

        
    }

    
}
