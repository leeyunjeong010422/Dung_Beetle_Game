using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish7 : MonoBehaviour
{
    public string SceneToLoad;

     void OnTriggerEnter(Collider other) 
   {
        if (other.CompareTag("Player")) {
            //스테이지 이동
            SceneManager.LoadScene(SceneToLoad);
        }
   }
}
