using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PersistanceManager : MonoBehaviour
{

    public static PersistanceManager Instance;
    public string _playerName;
    public int _highScore;
    public string _highScorePlayer;

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
        LoadPlayerData(); // load right from the start
    }

    [System.Serializable]
    class SaveData
    {
        //public string playerName;
        public int highScore;
        public string highScorePlayer;
    }

    public void SavePlayerData()
    {
        SaveData saveData = new SaveData();
        //saveData.playerName = _playerName;
        saveData.highScore = _highScore;
        saveData.highScorePlayer = _highScorePlayer;
        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(Application.persistentDataPath + "/playerSaveData.json", json);
    }

    public void LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/playerSaveData.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData saveData = JsonUtility.FromJson<SaveData>(json);

            //_playerName = saveData.playerName;
            _highScore = saveData.highScore;
            _highScorePlayer = saveData.highScorePlayer;
        }
    }
}
