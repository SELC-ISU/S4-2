﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetAxis("Vertical") > 0){
            anim.SetTrigger("jump");
            Invoke("ResetJump", 0.1f);
        }
        else if (Input.GetAxis("Vertical") < 0){
            anim.SetTrigger("down");
            Invoke("ResetDown", 0.1f);
        }
        
        if(Input.GetAxis("Horizontal") > 0){
            anim.SetBool("forward", true);
            anim.SetBool("back", false);
        }
        else if(Input.GetAxis("Horizontal") < 0){
            anim.SetBool("forward", false);
            anim.SetBool("back", true);
        }
        else {
            anim.SetBool("forward", false);
            anim.SetBool("back", false);
        }
    }
    public void ResetJump(){
        anim.ResetTrigger("jump");
    }
    public void ResetDown(){
        anim.ResetTrigger("down");
    }
}
