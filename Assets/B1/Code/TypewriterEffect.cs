using System.Collections;
using UnityEngine;
using TMPro;

public class TypewriterEffect : MonoBehaviour
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
        string fullText = "초등학생에게 채집된 쇠똥구리 똥그리!!\n똥들과 함께 고향에 있는 가족의 품으로\n돌아갈 수 있을까...?";  // 원하는 메시지 입력
        for (int i = 0; i <= fullText.Length; i++)
        {
            myText.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(typeDelay);
        }
    }
}