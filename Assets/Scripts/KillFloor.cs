using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillFloor : MonoBehaviour
{
    // When player hit the floor it restarts the scene

    private void OnTriggerEnter(Collider other)
    {
        //if player hits the floor this happens...
        if(other.CompareTag("Player")== true)
        {
            //restart the scene
            SceneManager.LoadScene(0);
        }
    }
}
