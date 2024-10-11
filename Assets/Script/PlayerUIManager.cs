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

    public void PlayerInfoBtn()
    {
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
    }
    public void BookBtn()
    {
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
    }
    public void UpgradeBtn()
    {
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
    }

    public void ShopBtn()
    {
        SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.ButtonSFX);
    }
}
