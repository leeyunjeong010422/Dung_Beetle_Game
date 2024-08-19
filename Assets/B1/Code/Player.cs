using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public Vector3 inputVec;
   public float movePower;
   public float jumpPower;
   public bool isGround;

    AudioSource audio;
    Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        inputVec.x = Input.GetAxis("Horizontal");
        inputVec.z = Input.GetAxis("Vertical");
        bool isJump = Input.GetButtonDown("Jump");

        if(isGround && isJump)
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    void FixedUpdate() 
    {
        if(isGround)
        {
        rigid .AddForce(inputVec * movePower);
        }
    }

    void OnCollisionStay(Collision other) {
         
         isGround = true;
    }

     void OnCollisionExit(Collision other) {
        isGround = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item")
        {
            audio.Play();
        }
    }
}
