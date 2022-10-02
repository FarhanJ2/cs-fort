using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyMenu : MonoBehaviour
{
    // Reference to PlayerStats.cs
    public PlayerStats playerStats;

    public bool hasPrimary = false;
    public bool hasSecondary = false;
    public Canvas BuyMenuUI;

    // Purchaseable Items
    public int armor = 650;
    public int USPS = 200;
    public int AUG = 3100;
    public int AK47 = 2700;
    
    public void OpenMenu()
    { 
        BuyMenuUI.enabled = !BuyMenuUI.enabled;
        Debug.Log("Input Worked");   
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            OpenMenu();
        }
    }

    public void PurchaseArmor()
    {
        if (playerStats.money >= armor)
        {
            playerStats.money = playerStats.money - armor;
            playerStats.hasArmor = true;
            playerStats.armor = 100;
            Debug.Log("Sucessfully Purchased");
        }
        else
        {
            Debug.Log("You Do Not Have Enough Money");
        }
    }


}
