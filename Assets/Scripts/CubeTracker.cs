using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTracker : MonoBehaviour
{
    public GameObject trackedObject;
    private Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(trackedObject != null){
            cameraTransform.position = new Vector3(cameraTransform.position.x , cameraTransform.position.y, trackedObject.transform.position.z);
        }
        
    }
}
