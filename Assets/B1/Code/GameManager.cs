using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isLive;
    public static int score;
    public static int health = 3;    
    public static int level = 1;    

    public static void InitializeGame()
    {
        level = 1; // 레벨 초기화
    }

    void Start()
    {
        isLive = true;
    }

     public static void GetItem() 
     {
        score += 100;
     }

      public static void Next() 
     {
        level += 1;
        SceneManager.LoadScene("Game");
     }
    
}