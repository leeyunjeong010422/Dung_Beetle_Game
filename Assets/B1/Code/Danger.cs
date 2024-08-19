using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Danger : MonoBehaviour
{
    public string SceneToLoad;

     void OnTriggerEnter(Collider other) 
   {
        if (other.CompareTag("Player")) {
            if(Life.lifeAmount>0){
            //생명력 감소
            Life.lifeAmount -=1;
            }

            //플레이어 원위치
            other.transform.position = Vector3.up;

        }
    }

    void Update()
    {
        // 목숨 끝나면 GameOver 씬으로 이동
        if(Life.lifeAmount==0){
            SceneManager.LoadScene(SceneToLoad);
            Life.lifeAmount = 3;
        }

        // 게임 클리어 하면 GameClear 씬으로 이동
    }
}
