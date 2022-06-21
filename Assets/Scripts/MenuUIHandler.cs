using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)] 
public class MenuUIHandler : MonoBehaviour
{
    private string playerInput;
    public TextMeshProUGUI BestScoreText;
    public TMP_InputField playerInputField;
    
    // Start is called before the first frame update
    void Start()
    {
        BestScoreText.text = $"Best Score : {PersistanceManager.Instance._highScorePlayer} : {PersistanceManager.Instance._highScore}";
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = playerInputField.text;
        PersistanceManager.Instance._playerName = playerInput;
    }

    public void StartGame() // method referenced in 'Start' button's OnClick
    {
        SceneManager.LoadScene(1); // as in 'File/Build Settings'
    }

    
}
