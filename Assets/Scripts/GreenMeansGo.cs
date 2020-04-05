using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenMeansGo : MonoBehaviour
{
    void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")){
            // Debug.Log(SceneManager.sceneCountInBuildSettings);
            // Debug.Log(SceneManager.GetActiveScene().buildIndex);
            // Debug.Log((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
        }
    }
}

