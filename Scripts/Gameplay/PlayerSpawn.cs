using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Reference to PlayerStats.cs
    public PlayerStats playerStats;
    public GameObject trigger;
    private GameObject player;
    
    void TeamSelect()
    {
        if (playerStats.isCT == true)
        {
            gameObject.transform.position = new Vector3(16f, 21.5f, 26f);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
