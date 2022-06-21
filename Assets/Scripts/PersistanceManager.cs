using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistanceManager : MonoBehaviour
{

    public static PersistanceManager Instance;
    public string playerName;

    private void Awake()
    {
        // Singleton patter. So that only one instance ever exist. Also, destroy PersistanceManager object if instance already exist.
        // We don't need new object poping up every time Awake is called
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); // don't destroy object when scene changes

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
