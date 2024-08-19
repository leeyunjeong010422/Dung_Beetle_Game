using System.Collections;
using UnityEngine;
using TMPro;

public class BlinkingText : MonoBehaviour
{
    private TextMeshProUGUI myText;
    public float blinkDuration = 1.0f;  // 알파 값이 0에서 1로 변화하는 데 걸리는 시간

    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();

        if (myText != null)
        {
            StartCoroutine(BlinkText());
        }
        else
        {
            Debug.LogError("TextMeshProUGUI component not found on this GameObject!");
        }
    }

    IEnumerator BlinkText()
    {
        while (true)
        {
            // 알파 값을 1에서 0으로 서서히 변화
            for (float t = 0; t < blinkDuration; t += Time.deltaTime)
            {
                myText.color = new Color(myText.color.r, myText.color.g, myText.color.b, Mathf.Lerp(1, 0, t/blinkDuration));
                yield return null;
            }

            // 알파 값을 0에서 1로 서서히 변화
            for (float t = 0; t < blinkDuration; t += Time.deltaTime)
            {
                myText.color = new Color(myText.color.r, myText.color.g, myText.color.b, Mathf.Lerp(0, 1, t/blinkDuration));
                yield return null;
            }
        }
    }
}