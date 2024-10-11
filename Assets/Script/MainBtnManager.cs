using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainBtnManager : MonoBehaviour
{
    public Text VersionText;
    public void StartBtn()
    {
        VersionText.text = "v." + Application.version;
        SceneManager.LoadScene("InGameScene");
    }
    public void ContiBtn()
    {
        SceneManager.LoadScene("InGameScene");
    }

    public Image SettingIMG;
    public void SettingBtn()
    {
        if(!SettingIMG.gameObject.activeSelf)
        {
            SettingIMG.gameObject.SetActive(true);
        }
        else if(SettingIMG.gameObject.activeSelf)
        {
            SettingIMG.gameObject.SetActive(false);
        }
    }
    public void ExitBtn()
    {
        Application.Quit();
    }
}
