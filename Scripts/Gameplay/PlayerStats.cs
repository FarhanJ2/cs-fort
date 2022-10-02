using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Reference to PlayerSpawn.cs
    public PlayerSpawn playerSpawn;
    public GameObject player;

    // Reference to WeaponIndexDatabase.cs
    public WeaponIndexDatabase weaponIndexDataBase;

    // Reference to BuyMenu.cs
    public BuyMenu buyMenu;

    // Player Team
    public bool isCT;
    public bool isT;

    // Player Weapons
    public bool hasArmor = false;
    public bool hasArmorHelmet = false;
    public bool hasBomb;
    public bool hasPrimary;
    public bool hasSecondary;
    public GameObject secondary;
    public GameObject primary;

    /* Need to Create Index for Weapon Base
     * 
     * Starting Pistols
     * 
     * Counter-Terrorists 
     * USPS = Index0 = 0
     * Terrorists
     * Glock18 = Index 1 = 1
     * 
     * Rest of the Secondary Pistols
     * P250 = Index 2 = 2
     * 
     * 
     * 
     * 
     * 
     */

    // Economy
    public int money = 800;

    // Health and Armor
    public int health = 100;
    public int armor = 0;
    public int armorHelmet = 0; 

    void SpawnCT()
    {
        if (isCT == true)
        {
            
        }
    }

    void SpawnT()
    {
        if (isT == true)
        {
            
        }
    }

    void KillPlayer()
    {
        if (health == 0)
        {
            Destroy(player);
        }
    }

    void Armor()
    {
        if (armor == 0)
        {
            hasArmor = false;
        }
        if (armorHelmet == 0)
        {
            hasArmorHelmet = false;
        }
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        KillPlayer();
        Armor();
    }
}
