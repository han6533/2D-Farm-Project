using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("���� �̸�")] public Text FarmNameText;
    public string FarmNameName;

    [Header("������ ��")] public int Gold;
    public Text Gold_Text;

    [Header("�� ���� �� ���� Ÿ�̸�")]public float Timer;
    [Header("��¥ ī��Ʈ")]public Text DaysTimeCount;
    public int Day_Count;
    public int Hour_Count;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        FarmNameText.text = DataManager.instance.data.FarmName + " ����";
    }
    private void Update()
    {
        Gold_Text.text = string.Format("{0:#,###}", Gold) + "��";
        DaysTimeCount.text = Day_Count + "��  " + Hour_Count + "��";

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
