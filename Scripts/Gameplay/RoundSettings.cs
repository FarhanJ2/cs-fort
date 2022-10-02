using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundSettings : MonoBehaviour
{
    // Gamemode Types
    // This is Default Settings for a Game
    public bool isCompetitive = true;
    public bool isCasual = false;
    
    // Game State 
    public bool roundEnd = false;
    public bool roundEndTime = false;

    // Score
    public int tScore = 0;
    public int ctScore = 0;

    // Parameters
    // Timers are in Seconds
    public int roundTimer;
    public int freezeTime;

    void competitiveSettings()
    {
        if (isCompetitive == true)
        {
            roundTimer = 90;
            freezeTime = 10;
        }
    }

    void casualSettings()
    {
        roundTimer = 130;
        freezeTime = 5;
    }

    void Start()
    {
        
    }

    // Next update in second
    private int nextUpdate = 1;

    // Update is called once per frame
    void Update()
    {

        // If the next update is reached
        if (Time.time >= nextUpdate)
        {
            //Debug.Log(Time.time + ">=" + nextUpdate);
            // Change the next update rn it is once per second
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            // Call your func
            UpdateEverySecond();
        }

    }

    // Update is called once per second
    void UpdateEverySecond()
    {
        roundTimer--;
        Debug.Log(roundTimer);
        if (roundTimer == 0)
        {
            roundEnd = true;
        }
        if (roundTimer == -5)
        {
            roundEndTime = true;
        }
    }

    void RoundEnd()
    {
        
        // Program the respawn of players to spawn
        if (roundEndTime == true && isCompetitive == true)
        {
            competitiveSettings();
        }
        if (roundEndTime == true && isCasual == true)
        {
            casualSettings();
        }
    }
}

