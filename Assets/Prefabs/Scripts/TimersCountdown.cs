using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;
    public CodeyMove Cm;
    TriggerFinishLine TriggerFinishLine;
    public float totalLapTime;
    public float totalCountdownTime;  
    // Update is called once per frame
    void Update()
    {
        // totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        lapTime.text = totalLapTime.ToString();
        startCountdown.text = totalCountdownTime.ToString();

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();  
           
        if (totalCountdownTime < 0)
        {
        print("Time is up!");
        Cm.Speed = 30;
        }
        
        if (totalCountdownTime > 0)
        {
            lapTime.text = "";
            totalCountdownTime -= Time.deltaTime;
            Cm.Speed = 0;

        }

        if (totalCountdownTime <= 0)
        {
            lapTime.text = "400";
            lapTime.text = totalLapTime.ToString();
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
        }

        if (totalLapTime <= 0)
        {
            SceneManager.LoadScene(1);
        }

        // if (totalLapTime > 0 && checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
        // {
        // }

    }   
    
}
