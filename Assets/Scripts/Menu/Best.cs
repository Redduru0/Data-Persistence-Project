using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Best : MonoBehaviour
{
    public static Best Instance;

    public string bestPlayer;
    public string PlayerName;

    public int bestScore;
    public int score;

    public void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadBest();
    }

    [System.Serializable]
    class SaveData
    {
        public int saveScore;
        public string saveName;
    }

    public void SaveBest(int bestScore, string bestPlayer)
    {
        SaveData data = new SaveData();
        data.saveScore = bestScore;
        data.saveName = bestPlayer;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBest()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            bestScore = data.saveScore;
            bestPlayer = data.saveName;
        }
    }
}
