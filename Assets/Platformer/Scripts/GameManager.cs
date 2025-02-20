using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI pointText;

    public Transform camera;
    public float xPosition = 15.15f;

    public int coinCount;
    public int pointCount;

    void Update()
    {
        int timeLeft = 300 - (int)Time.time;
        timerText.text = $"Time: {timeLeft}";

        if (coinCount < 10)
        {
            coinText.text = $"x0{coinCount}";
        }
        else
        {
            coinText.text = $"x{coinCount}";
        }

        pointText.text = $"{pointCount}";

        if (Input.GetKey(KeyCode.D))
        {
            if(xPosition > 192.15f)
            {
                xPosition = 192.15f;
            }

            camera.transform.position = new Vector3(++xPosition, 7.47f, -1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (xPosition < 15.15f)
            {
                xPosition = 15.15f;
            }
            camera.transform.position = new Vector3(--xPosition, 7.47f, -1f);
        }
    }
}
