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
    /*
    물 뿌리개 업그레이드
    레벨 0 : 3초
    레벨 1 : 2초
    레벨 2 : 스프링 쿨러
    레벨 3 : 농약 들어가있는 스프링 쿨러*/
    public int Watering_Level_Index;
    public SpriteRenderer Watering_Item;
    public Sprite[] Watering_Sprite;
    public void Upgrad_watering()
    {
        switch (Watering_Level_Index)
        {
            case 0:
                if(GameManager.Instance.Gold >= 5000)
                {
                    GameManager.Instance.Gold -= 5000;
                    Watering_Item.sprite = Watering_Sprite[0];
                    Watering_Level_Index++;
                }
                break;
            case 1:
                if(GameManager.Instance.Gold >= 10000)
                {
                    GameManager.Instance.Gold -= 10000;
                    Watering_Item.sprite = Watering_Sprite[1];
                    Watering_Level_Index++;
                }
                break;
            case 2:
                if(GameManager.Instance.Gold >= 20000)
                {
                    GameManager.Instance.Gold -= 20000;
                    Watering_Item.sprite = Watering_Sprite[2];
                    Watering_Level_Index++;
                }
                break;
        }
    }
}
