using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextTrigger : MonoBehaviour
{
    public GameObject textLabel;
    private void OnTriggerEnter(Collider other)
    {
        textLabel.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    { 
        textLabel.SetActive(false);
    }
}
