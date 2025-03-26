using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;

    
private void OnTriggerEnter(Collider other)
{
    if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
    {
        print("You Win! However, you did horribly and barely managed to scrape out a victory.");
        SceneManager.LoadScene(2);

    }
    else{
        print("You are a cheater. You have failed at life. You have proven yourself unworthy of living. Go take a hike!Translation to Sherlockian: [...] Go fall of Reichenbach falls!");
    }
}
}
