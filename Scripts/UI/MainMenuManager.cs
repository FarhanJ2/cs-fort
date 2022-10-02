using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] Canvas JoinLobby;
    [SerializeField] Canvas MainMenu;
    [SerializeField] Canvas SettingsMenu;
    [SerializeField] Canvas UserSettings;
    [SerializeField] Slider sensitivitySlider;

    public float mouseSensitivity = 100f;
    

    // Reference to MouseLook.cs

    public MouseLook mouseLook;

    public void ShowGameJoin()
    {
        JoinLobby.enabled = !JoinLobby.enabled;
    }

    public void ShowMainMenu()
    {
        MainMenu.enabled = !MainMenu.enabled;
    }

    public void ShowSettingsMenu()
    {
        SettingsMenu.enabled = !SettingsMenu.enabled;
    }

   public void Sensitivity()
    {
        if (mouseSensitivity == 0)
        {
            mouseSensitivity = 100f;
        }
    }

    public void Next()
    {
        UserSettings.enabled = !UserSettings.enabled;
    }
    
    void Start()
    {
        
        Sensitivity();
    }

    void Awake()
    { 
        MainMenu.enabled = true;
        JoinLobby.enabled = false;
        SettingsMenu.enabled = false;
        UserSettings.enabled = false;
    }
   
    // Update is called once per frame
    void Update()
    {
        mouseSensitivity = sensitivitySlider.value;
    }
}
