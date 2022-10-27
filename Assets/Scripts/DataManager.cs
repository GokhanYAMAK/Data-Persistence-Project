using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
   

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    //[System.Serializable]
    //class SaveData
    //{
    //    public Text PlayerName;
    //    public Text Score;
    //    public Text BestPlayer;
    //    public Text BestScore;
    //}

    //public void SavePlayer()
    //{
    //    SaveData data = new();
    //    //MainManager player = gameObject.AddComponent<MainManager>();

    //    data.PlayerName.text = PlayerName.text;

    //    string json = JsonUtility.ToJson(data);

    //    File.WriteAllText(Application.persistentDataPath + "/savefile.json" , json);
        
    //}

    //public void LoadPlayer()
    //{
    //    string path = Application.persistentDataPath + "/savefile.json";
    //    MainManager player = new MainManager();
    //    if (File.Exists(path))
    //    {
    //        string json = File.ReadAllText(path);
    //        SaveData data = JsonUtility.FromJson<SaveData>(json);
            
    //        player.PlayerName.text = data.PlayerName.text;
    //    }
    //}
}
