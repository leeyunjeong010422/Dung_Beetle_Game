using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   void OnTriggerEnter(Collider other) 
   {
        if (other.CompareTag("Player")) {
            //점수 얻기
            InGame.coinAmount +=10;

            //사운드
            ItemSound.SoundPlay();

            //아이템 삭제
            Destroy(gameObject);
        }
    }
}
