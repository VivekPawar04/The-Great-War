using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float CurrentTime = 0;
    public float StartTime = 60f;
    public float CriticalTime = 10f;
    int minutes;
    int seconds;
    [SerializeField] Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        print(122%60);
        CurrentTime = StartTime;
    }

    // Update is called once per frame
    void Update()
    {
        minutes = (int)CurrentTime/60;
        seconds = ((int)CurrentTime)%60;

        if (TurnDecision.TimerStart == false/*true*/)
        {
            if(CurrentTime < CriticalTime)
            {
                TimerText.color = Color.red;
            }

            if(CurrentTime >= 0)
            
            {
                if(seconds >= 10)
                {
                    TimerText.text = (minutes).ToString() + ":" + (seconds).ToString ("0");
                }
                else
                {
                    TimerText.text = (minutes).ToString() + ":" + "0" + (seconds).ToString ("0");
                }
        }

            CurrentTime -= 1 * Time.deltaTime;

        }
    }
}
