using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RedMeansDead : MonoBehaviour
{
    public GameObject objToDestroy;


    void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")){
            //Destroy(objToDestroy);
            //reload scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}

