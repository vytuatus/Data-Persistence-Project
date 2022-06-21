using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    private string playerInput;
    public TMP_InputField playerInputField;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = playerInputField.text;
        PersistanceManager.Instance.playerName = playerInput;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1); // as in 'File/Build Settings'
    }
}
