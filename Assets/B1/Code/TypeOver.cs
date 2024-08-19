using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeOver : MonoBehaviour
{
    private TextMeshProUGUI myText;
    public float typeDelay = 0.1f;  // 각 글자가 나타나는 사이의 시간 간격

    private void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();

        if (myText != null)
        {
            StartCoroutine(TypeText());
        }
        else
        {
            Debug.LogError("TextMeshProUGUI component not found on this GameObject!");
        }
     }

    IEnumerator TypeText()
    {
        myText.text = "";  // 텍스트를 초기화
        string fullText = "똥그리가 고향으로 돌아가지 못 했어요...\n똥그리가 고향에 있는 가족의 품으로 안전하게 \n돌아갈 수 있게 다시 도와주세요!!";  // 원하는 메시지 입력
        for (int i = 0; i <= fullText.Length; i++)
        {
            myText.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(typeDelay);
        }
    }
}
