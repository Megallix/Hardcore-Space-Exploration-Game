using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame2 : MonoBehaviour
{
    float roundStartDelayTime = 3;

    float roundStartTime;
    int waitTime;
    bool roundStarted;

    // Start is called before the first frame update
    void Start()
    {
        print("Press the spacebar once you think the allotted time is up.");
        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted)
        {
            InputReceived();
        }
    }

    void InputReceived()
    {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        print("You waited for " + playerWaitTime + " seconds. That's " + error + " seconds off. " + GenerateMessage(error));
        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    string GenerateMessage(float error)
    {
        string message = "";
        if (error == 0)
        {
            message = "Timing god!";
        }
        else if (error < .15f)
        {
            message = "Incredible!";
        }
        else if (error < .75f)
        {
            message = "Excellent!";
        }
        else if (error < 1.25f)
        {
            message = "Close enough.";
        }
        else if (error < 1.75f)
        {
            message = "Not that great.";
        }
        else if (error < 2f)
        {
            message = "Pretty bad...";
        }
        else if (error < 5f)
        {
            message = "Better than Omniize.";
        }
        else if (error < 7f)
        {
            message = "Still better than Omniize.";
        }
        else if (error < 10f)
        {
            message = "How can you even be this bad?";
        }
        else
        {
            message = "Idiot.";
        }

        return message;
    }

    void SetNewRandomTime()
    {
        waitTime = Random.Range(5, 21);
        roundStartTime = Time.time;
        roundStarted = true;

        print(waitTime + " seconds.");
    }


}
