using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeGameUI : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public float Timer;

    void Update()
    {
        Timer += Time.deltaTime;
        TimerText.text = "생존 시간 : " + Timer.ToString("0.00");
    }
}
