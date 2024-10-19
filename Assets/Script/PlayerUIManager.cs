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
        }
        else if (!isPlayerUI)
        {
            isPlayerUI = true;
            PlayerUIBtn_Text.text = "À§";
        }
        StartCoroutine(Move_PlayerUI());
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

    public Image MapIMG;
    public float CurTime;
    public IEnumerator Move_PlayerUI()
    {
        Debug.Log("Move_PlayerUI");
        CurTime = 0f;
        while (CurTime < 1)
        {
            CurTime += 0.03f;
            yield return new WaitForSeconds(0.001f);
            //float t = CurPlayerStatusTime / 1;
            //t = Mathf.Sin(t * Mathf.PI * 0.5f);

            if (isPlayerUI)
                MapIMG.transform.localPosition = Vector2.Lerp(new Vector2(0, -968), new Vector2(0, -1473), CurTime);
            if (!isPlayerUI)
                MapIMG.transform.localPosition = Vector2.Lerp(new Vector2(0, -1473), new Vector2(0, -968), CurTime);
        }
    }
}
