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
    { // ���� ���ǰ� � ������Ʈ�� �浹 ���̶��
        if (isColliding)
        {
            // Ÿ�̸Ӹ� ������Ŵ
            timer += Time.deltaTime;

            // Ÿ�̸Ӱ� ���� �ð��� �ʰ��ϸ� ������ ��Ȱ��ȭ
            if (timer >= delay)
            {
                GetComponent<Renderer>().material.color = Color.blue;
                gameObject.SetActive(false);
            }
        }
    }

    // ���ǰ� �浹�� ���� ȣ��Ǵ� �Լ�
    void OnCollisionEnter(Collision collision)
    {
        // ���ǰ� �浹�� ������Ʈ�� ����
        isColliding = true;

        // Ÿ�̸� �ʱ�ȭ
        timer = 0f;
    }

    // �浹�� ���� �� ȣ��Ǵ� �Լ�
    void OnCollisionExit(Collision collision)
    {
        // �浹�� �������Ƿ� �ʱ�ȭ
        isColliding = false;
    }

}