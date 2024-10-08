using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("소유한 돈")] public int Gold;

    [Header("낮 저녁 밤 변경 타이머")]public float Timer;
    [Header("날짜 카운트")]public int DayCount;
}
