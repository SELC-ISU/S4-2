using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] float rotationalThrust = 30;
    [SerializeField] float thrust = 5;
    [SerializeField] float jumpPower = 15;
    Rigidbody rigidBody;
    private bool canJump = true;

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
            transform.Rotate(Vector3.right * -rotationThisFrame);
            rigidBody.AddForce(Vector3.back * thrust);

        }
        else if(Input.GetAxis("Horizontal") < 0){
            float rotationThisFrame = rotationalThrust * Time.deltaTime;
            transform.Rotate(Vector3.left * -rotationThisFrame);
            rigidBody.AddForce(Vector3.forward * thrust);
        }
        if (Input.GetButtonDown("Jump") && canJump)
        {
            float rotationThisFrame = rotationalThrust * Time.deltaTime;
            rigidBody.AddForce(Vector3.up * jumpPower);
            canJump = false;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rigidBody.mass = 10;
        }
        else{
            rigidBody.mass = 1;
        }
    }

    void OnCollisionEnter(Collision collision){
        canJump = true;
    }
}
