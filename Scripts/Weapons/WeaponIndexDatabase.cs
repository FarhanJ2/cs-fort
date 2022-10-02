using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponIndexDatabase : MonoBehaviour
{
    // Reference to BuyMenu.cs
    public BuyMenu buyMenu;

    // Reference to PlayerStats.cs
    public PlayerStats playerStats;


    public GameObject USPS; // 0
    public GameObject Glock18; // 1
    public GameObject P250; // 2
    
    public GameObject FAMAS; //

    public GameObject Flashbang; //
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Item Prices

    public int USPS_price = 200;
    public int Glock18_price = 200;
    public int P250_price = 300;

    void USPSPurchase()
    {
        if (playerStats.money >= 200)
        {


        }
    }
}
