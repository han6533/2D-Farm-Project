using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

[Serializable]
public class Data
{
    [Header("이름 설정")]
    public bool isFarmNameSetting;
    public string FarmName;
}

[Serializable]
public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public Data data;
    private void Start()
    {
        instance = this;
        LoadDataToJson();
    }
    [ContextMenu("Reset Json Data")]
    public void ResetDataToJson()
    {
        data.FarmName = "이름 없는";
        data.isFarmNameSetting = false;

        string GameData = JsonUtility.ToJson(data, true);
        string path = Path.Combine(Application.persistentDataPath, "GameData.json");
        File.WriteAllText(path, GameData);

        SceneManager.LoadScene("InGameScene");
        //LoadingScene.LoadScene(SceneManager.GetActiveScene().name);
        //LoadingScene.LoadScene(data.SceneName);
    }

    //private void Update()
    //{
    //    data.FarmName = Tutorial_Manaer.Instance.FarmNameInputText.text.ToString();
    //}
    [ContextMenu("To Json Data")]
    public void SaveDataToJson()
    {
        Debug.Log("저장 중..");

        data.isFarmNameSetting = Tutorial_Manaer.Instance.isFarmNameSetting;
        data.FarmName = Tutorial_Manaer.Instance.FarmNameInputText.text.ToString();
        Debug.Log(data.FarmName);
         
        string GameData = JsonUtility.ToJson(data, true);
        string path = Path.Combine(Application.persistentDataPath, "GameData.json");
        File.WriteAllText(path, GameData);
        PlayerPrefs.Save();
        Debug.Log("저장 됨");
    }

    [ContextMenu("From Json Data")]
    public void LoadDataToJson()
    {
        string path = Path.Combine(Application.persistentDataPath, "GameData.json");
        string Data = File.ReadAllText(path);
        data = JsonUtility.FromJson<Data>(Data);

        Tutorial_Manaer.Instance.isFarmNameSetting = data.isFarmNameSetting;
        Tutorial_Manaer.Instance.FarmNameInputText.text = data.FarmName;
        Debug.Log(data.FarmName);

        Debug.Log("로드 완료");
    }
}
