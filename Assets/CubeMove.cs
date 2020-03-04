using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] float rotationalThrust = 300f;
    [SerializeField] float thrust = 300f;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0){
            float rotationThisFrame = rotationalThrust * Time.deltaTime;
            //transform.Rotate(Vector3.right * -rotationThisFrame);
            rigidBody.AddForce(Vector3.back * thrust);

        }
        else if(Input.GetAxis("Horizontal") < 0){
            float rotationThisFrame = rotationalThrust * Time.deltaTime;
            //transform.Rotate(Vector3.left * -rotationThisFrame);
            rigidBody.AddForce(Vector3.forward * thrust);
        }
    }
}
