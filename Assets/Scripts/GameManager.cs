using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text messageText;
    float timeCounter = 0.0f;
    public GameObject balloon;
    bool isCounting = false;

    // Start is called before the first frame update
    void Start()
    {
        messageText.text = timeCounter.ToString("f1");
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting == true) {
            timeCounter += Time.deltaTime;
            messageText.text = timeCounter.ToString("f1");
            balloon.transform.localScale = new Vector3(1, 1, 1) * 0.3f * timeCounter;
        }
    }

    public void StartButton() {
        isCounting = true;
        timeCounter = 0.0f;
    }

    public void StopButton() {
        isCounting = false;
        if (timeCounter >= 9.00f) {
            messageText.text = "GOOD";
            if (timeCounter > 9.95f) {
                messageText.text = "PERFECT";
            }
            if (timeCounter > 11.0f) {
                messageText.text = "MISS";
            }
        } else {
            messageText.text = "MISS";
        }
    }
}
