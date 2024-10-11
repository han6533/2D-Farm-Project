using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_Manaer : MonoBehaviour
{
    public static Tutorial_Manaer Instance;

    public bool isFarmNameSetting;
    public Image FarmNameSettingIMG;
    public InputField FarmNameInputText;
  
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        if(!isFarmNameSetting)
        {
            FarmNameSettingIMG.gameObject.SetActive(true);
        }
    }
    public void NameSettingCompletionBtn()
    {
        if(FarmNameInputText.text != "" && FarmNameInputText.text == Regex.Replace(FarmNameInputText.text, @"[^1-10a-zA-Z°¡-ÆR]", ""))
        {
            GameManager.Instance.FarmNameName = FarmNameInputText.text;
            isFarmNameSetting = true;
            FarmNameSettingIMG.gameObject.SetActive(false);
            GameManager.Instance.FarmNameText.text = GameManager.Instance.FarmNameName + " ³óÀå";
            DataManager.instance.SaveDataToJson();
            Tutorial();
        }
        else
            FarmNameInputText.text = "";
    }

    public Image TutorialIMG;
    public Text TutorialText;
    public int Tutorial_Index;
    public string Tutorial_str;
    public void Tutorial()
    {
        Tutorial_Index++;
        TutorialIMG.gameObject.SetActive(true);
        switch (Tutorial_Index)
        {
            case 0:
                Tutorial_str = "¹Ý°©½À´Ï´Ù. " + GameManager.Instance.FarmNameName + "´Ô" + " È¯¿µÇÕ´Ï´Ù.\n";
                break;
            case 1:
                Tutorial_str = "";
                break;
        }
        Typing_Text();
    }

    public IEnumerator Typing_Text()
    {
        Debug.Log("ÄÚ·çÆ¾ ½ÇÇà");
        TutorialText.text = "";
        for (int i = 0; i <= Tutorial_str.Length; i++)
        {
            TutorialText.text = Tutorial_str.Substring(0, i);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
