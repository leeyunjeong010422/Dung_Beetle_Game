using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageScore : MonoBehaviour
{
    Text text;
    public static int StageAmount = 1;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = StageAmount.ToString();
    }
}
