using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;

public class SimpleUI : MonoBehaviour
{
    public TextMeshProUGUI Ddaytext;
    public TextMeshProUGUI ItemInputtext;
    public TextMeshProUGUI ResultInputtext;
    public TextMeshProUGUI DdaytextValue;
    public TextMeshProUGUI Timetext;
    int currentDday = 1;
    float seconds;
    float minutes;
    float hours;
    string curretItem = "롱소드";
    int result = 1000;

    // Start is called before the first frame update
    void Start()
    {
        NextDday(9);
        Ddaytext.text = "D-day " + currentDday;
        DdaytextValue.text = "1";
        ItemInputtext.text = curretItem;
        ResultInputtext.text = "금일 결과" + result + "원";
    }

    // Update is called once per frame
    void Update()
    {
        FlowTime();
    }

    void NextDday(int time)
    {
        currentDday = currentDday + time;
    }
    void FlowTime()
    {
        seconds += Time.deltaTime;
        Debug.Log($"현재 시간 : {hours} : {minutes} : {seconds}");
        Timetext.text = $"{hours} : {minutes} : {seconds}";

        if (seconds >= 60)
        {
            seconds = 0;
            minutes = minutes + 1;
        }

        if (minutes >= 60)
        {
            minutes = 0;
            hours = hours + 1;
        }

    }
}



