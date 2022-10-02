using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    // Reference to PlayerStats.cs
    public PlayerStats playerStats;

    [SerializeField] Canvas pauseMenu;
    [SerializeField] Canvas settingsMenu;
    [SerializeField] Canvas gameMenu;
    [SerializeField] Canvas buyMenu;
    [SerializeField] Canvas teamSelect;


    public void choseCT()
    {
        playerStats = FindObjectOfType<PlayerStats>();
        playerStats.isCT = true;
        playerStats.isT = false;
        teamSelect.enabled = false;
        gameMenu.enabled = true;
        Debug.Log("You are Now a Counter-Terrorist");
    }

    public void choseT()
    {
        playerStats = FindObjectOfType<PlayerStats>();
        playerStats.isT = true;
        playerStats.isCT = false;
        teamSelect.enabled = false;
        gameMenu.enabled = true;
        Debug.Log("You are Now a Terrorist");
    }

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.enabled = false;
        settingsMenu.enabled = false;
        gameMenu.enabled = false;
        buyMenu.enabled = false;
        teamSelect.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
