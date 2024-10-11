using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerUIManager : MonoBehaviour
{
    [Header("Player UI")]
    public Image Player_UI;
    public bool isPlayerUI;
    public Text PlayerUIBtn_Text;
    public void Player_UI_UpDownBtn()
    {
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
        if (isPlayerUI)
        {
            isPlayerUI = false;
            PlayerUIBtn_Text.text = "¾Æ·¡";
            Player_UI.transform.localPosition = new Vector3(0, -962, 0);
        }
        else if (!isPlayerUI)
        {
            isPlayerUI = true;
            PlayerUIBtn_Text.text = "À§";
            Player_UI.transform.localPosition = new Vector3(0, -1473, 0);
        }
    }

    public Image[] PlayerBox;
    
    public void PlayerInfoBtn()
    {
        PlayerBox[0].gameObject.SetActive(true);
        PlayerBox[1].gameObject.SetActive(false);
        PlayerBox[2].gameObject.SetActive(false);
        PlayerBox[3].gameObject.SetActive(false);
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
    }
    public void BookBtn()
    {
        PlayerBox[0].gameObject.SetActive(false);
        PlayerBox[1].gameObject.SetActive(true);
        PlayerBox[2].gameObject.SetActive(false);
        PlayerBox[3].gameObject.SetActive(false);
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
    }
    public void UpgradeBtn()
    {
        PlayerBox[0].gameObject.SetActive(true);
        PlayerBox[1].gameObject.SetActive(false);
        PlayerBox[2].gameObject.SetActive(true);
        PlayerBox[3].gameObject.SetActive(false);
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
    }

    public void ShopBtn()
    {
        PlayerBox[0].gameObject.SetActive(false);
        PlayerBox[1].gameObject.SetActive(false);
        PlayerBox[2].gameObject.SetActive(false);
        PlayerBox[3].gameObject.SetActive(true);
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
    }
}
