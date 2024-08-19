using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecleartext : MonoBehaviour
{
    Text text;
   
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = InGame.coinAmount.ToString();
    }
}
