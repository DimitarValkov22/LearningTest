using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimatorController : MonoBehaviour
{
    private Animator anim;
    private float speed = 2f;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("IsRunning", true);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("IsGrounded", true);
        }
        else
        {
            anim.SetBool("IsGrounded", false);
        }
    }
}
