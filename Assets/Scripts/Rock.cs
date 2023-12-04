using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{

    //this is another variable
    [SerializeField] private Material red;

    //when player collides with the rock
    //we restart the scene

    //collision doesn't work everytime but Aaron said it's fine

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            SceneManager.LoadScene(0);
        }

        //when rock hits the floor it changes colours
        //from gold to red

        if (collision.gameObject.CompareTag("Floor") == true)
        {
           //changes colours/material
           gameObject.GetComponent<Renderer>().material = red;
        }
    }


}
