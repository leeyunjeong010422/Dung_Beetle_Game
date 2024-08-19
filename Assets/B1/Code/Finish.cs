using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
     void OnTriggerEnter(Collider other) 
   {
        if (other.CompareTag("Player")) {
            //스테이지 이동
            GameManager.Next();
            
            if(StageScore.StageAmount<8){
            //스테이지 증가
            StageScore.StageAmount +=1;
            }

            //사운드
            other.transform.position = Vector3.up;

        }
    }
}