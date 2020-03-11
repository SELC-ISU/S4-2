using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMeansDead : MonoBehaviour
{
    public GameObject objToDestroy;


    void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")){
            Destroy(objToDestroy);
        }
    }
}

