using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CampfireExit : MonoBehaviour
{
    public GameObject Lumni;

    private int SceneLoad;

    public KeyCode keyToPress;

    private bool isCharacterNearby = false;

    public GameObject textLabel;

    private void CampfireReached()
    {
        //when this code is activated, it brings us to the load scene
        SceneManager.LoadScene(0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            isCharacterNearby = true;

            textLabel.SetActive(true);
            Debug.Log("Campfire reached");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        isCharacterNearby = false;

        textLabel.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(keyToPress) && isCharacterNearby == true)
        {
            Debug.Log("Campfire reached. Pressed E");

            CampfireReached();
        }
    }
}
