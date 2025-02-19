using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    void Update()
    {
        int timeLeft = 300 - (int)Time.time;
        timerText.text = $"Time: {timeLeft}";
    }
}
