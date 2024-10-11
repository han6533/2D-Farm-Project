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
        if(FarmNameInputText.text != "" && FarmNameInputText.text == Regex.Replace(FarmNameInputText.text, @"[^1-10a-zA-Z��-�R]", ""))
        {
            GameManager.Instance.FarmNameName = FarmNameInputText.text;
            isFarmNameSetting = true;
            FarmNameSettingIMG.gameObject.SetActive(false);
            GameManager.Instance.FarmNameText.text = GameManager.Instance.FarmNameName + " ����";
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
                Tutorial_str = "�ݰ����ϴ�. " + GameManager.Instance.FarmNameName + "��" + " ȯ���մϴ�.\n";
                break;
            case 1:
                Tutorial_str = "";
                break;
        }
        Typing_Text();
    }

    public IEnumerator Typing_Text()
    {
        Debug.Log("�ڷ�ƾ ����");
        TutorialText.text = "";
        for (int i = 0; i <= Tutorial_str.Length; i++)
        {
            TutorialText.text = Tutorial_str.Substring(0, i);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
