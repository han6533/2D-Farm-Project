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
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
        if (FarmNameInputText.text != "" && FarmNameInputText.text == Regex.Replace(FarmNameInputText.text, @"[^0-9a-zA-Z∞°-∆R]", ""))
        {
            GameManager.Instance.FarmNameName = FarmNameInputText.text;
            isFarmNameSetting = true;
            FarmNameSettingIMG.gameObject.SetActive(false);
            GameManager.Instance.FarmNameText.text = GameManager.Instance.FarmNameName + " ≥Û¿Â";
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
    public bool isTyping;
    public void Tutorial()
    {
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
        if (!isTyping)
        {
            Tutorial_Index++;
            TutorialIMG.gameObject.SetActive(true);
            switch (Tutorial_Index)
            {
                case 1:
                    Tutorial_str = "π›∞©Ω¿¥œ¥Ÿ. " + GameManager.Instance.FarmNameName + "¥‘" + " »Øøµ«’¥œ¥Ÿ.\n";
                    break;
                case 2:
                    Tutorial_str = "¿Ã∞˜¿Ã æ’¿∏∑Œ ªÁøÎ«œΩ√∞‘ µ… ≈Õ¿‘¥œ¥Ÿ.\n∂•¿ª ±∏∏≈«ÿ πÁ¿ª ¿œ±≈¡÷ººø‰.";
                    break;
                case 3:
                    Tutorial_str = "ªÛ¡°ø°º≠ ∂•¿ª ±∏∏≈«ÿ, πÁ¿ª ∞°≤‹ ºˆ ¿÷Ω¿¥œ¥Ÿ.";
                    break;
                case 4:
                    TutorialIMG.gameObject.SetActive(false);
                    break;
            }
            StartCoroutine(Typing_Text());
        }
    }

    public IEnumerator Typing_Text()
    {
        isTyping = true;
        Debug.Log("ƒ⁄∑Á∆æ Ω««‡");
        TutorialText.text = "";
        for (int i = 0; i <= Tutorial_str.Length; i++)
        {
            TutorialText.text = Tutorial_str.Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }
        isTyping = false;
    }
}
