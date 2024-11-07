using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public SpriteRenderer[] Floor_Sprite;
    public Sprite[] Floor_Sprtie;
    public int FarmFloor_Index = -1;
    public Text FarmBuyBtn_Text;
    public void Buy_farm_Floor()
    {
        FarmFloor_Index++;
        switch (FarmFloor_Index)
        {
            case 0:
                if (GameManager.Instance.Gold >= 1000)
                {
                    GameManager.Instance.Gold -= 1000;
                    Floor_Sprite[FarmFloor_Index].sprite = Floor_Sprtie[0];
                    Floor_Sprite[FarmFloor_Index].name = "Farm0";
                }
                break;
            case 1:
                if (GameManager.Instance.Gold >= 3000)
                {
                    GameManager.Instance.Gold -= 3000;
                    Floor_Sprite[FarmFloor_Index].sprite = Floor_Sprtie[0];
                    Floor_Sprite[FarmFloor_Index].name = "Farm1";
                }
                break;
            case 2:
                if (GameManager.Instance.Gold >= 7000)
                {
                    GameManager.Instance.Gold -= 7000;
                    Floor_Sprite[FarmFloor_Index].sprite = Floor_Sprtie[0];
                    Floor_Sprite[FarmFloor_Index].name = "Farm2";
                }
                break;
            case 3:
                if (GameManager.Instance.Gold >= 15000)
                {
                    GameManager.Instance.Gold -= 15000;
                    Floor_Sprite[FarmFloor_Index].sprite= Floor_Sprtie[0];
                    Floor_Sprite[FarmFloor_Index].name = "Farm3";
                }
                break;
            case 4:
                if (GameManager.Instance.Gold >= 30000)
                {
                    GameManager.Instance.Gold -= 30000;
                    Floor_Sprite[FarmFloor_Index].sprite = Floor_Sprtie[0];
                    Floor_Sprite[FarmFloor_Index].name = "Farm4";
                }
                break;
            case 5:
                if (GameManager.Instance.Gold >= 50000)
                {
                    GameManager.Instance.Gold -= 50000;
                    Floor_Sprite[FarmFloor_Index].sprite = Floor_Sprtie[0];
                    Floor_Sprite[FarmFloor_Index].name = "Farm5";
                    FarmBuyBtn_Text.text = "X";
                }
                break;
        }
    }
}
