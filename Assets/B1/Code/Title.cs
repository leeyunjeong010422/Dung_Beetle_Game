using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public string SceneToLoad;

     void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(SceneToLoad);
            InGame.coinAmount = 0;
            Life.lifeAmount = 3;
            StageScore.StageAmount = 1;

            GameManager.InitializeGame();
        }
    }
}
