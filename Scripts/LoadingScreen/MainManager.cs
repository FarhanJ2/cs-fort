using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{ 
    public static MainManager Instance;

    public GameObject mainManager;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ScriptTransfer(GameObject gameObject)
    {
        MainManager.Instance.mainManager = gameObject;
    }

    private void Start()
    {
        if (MainManager.Instance != null)
        {
            
        }
    }
}
