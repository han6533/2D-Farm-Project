using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("³óÀå ÀÌ¸§")] public Text FarmNameText;
    public string FarmNameName;

    [Header("¼ÒÀ¯ÇÑ µ·")] public int Gold;
    public Text Gold_Text;

    [Header("³· Àú³á ¹ã º¯°æ Å¸ÀÌ¸Ó")]public float Timer;
    [Header("³¯Â¥ Ä«¿îÆ®")]public Text DaysTimeCount;
    public int Day_Count;
    public int Hour_Count;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        FarmNameText.text = DataManager.instance.data.FarmName + " ³óÀå";
    }
    private void Update()
    {
        Gold_Text.text = string.Format("{0:#,###}", Gold) + "¿ø";
        DaysTimeCount.text = Day_Count + "ÀÏ  " + Hour_Count + "½Ã";

        Timer += Time.deltaTime;
        if(Timer >= 40f)
        {
            Timer = 0;
            Hour_Count++;
            if(Hour_Count >= 24)
            {
                Hour_Count = 0;
                Day_Count++;
            }
        }
    }
}
