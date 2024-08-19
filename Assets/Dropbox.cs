using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropdropbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        originalMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame

    private bool isColliding = false;
    private float timer = 0f;
    private float delay = 2f;
    private Material originalMaterial;

    void Update()
    { // 만약 발판과 어떤 오브젝트가 충돌 중이라면
        if (isColliding)
        {
            // 타이머를 증가시킴
            timer += Time.deltaTime;

            // 타이머가 지연 시간을 초과하면 발판을 비활성화
            if (timer >= delay)
            {
                GetComponent<Renderer>().material.color = Color.blue;
                gameObject.SetActive(false);
            }
        }
    }

    // 발판과 충돌한 순간 호출되는 함수
    void OnCollisionEnter(Collision collision)
    {
        // 발판과 충돌한 오브젝트를 추적
        isColliding = true;

        // 타이머 초기화
        timer = 0f;
    }

    // 충돌이 끝날 때 호출되는 함수
    void OnCollisionExit(Collision collision)
    {
        // 충돌이 끝났으므로 초기화
        isColliding = false;
    }

}