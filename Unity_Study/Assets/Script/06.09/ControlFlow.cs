using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class ControlFlow : MonoBehaviour
{
    int count;
    public TMP_Text outputText;
    void Awake()
    {
        count = 0;
    }
    public void Gacha()
    {
        string allGachaResults = "";
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101);
            string currentResult = "";
            Debug.Log($"랜덤 값:  {randomValue} 입니다");
            if (8 <= count)
            {
                currentResult = ("확정으로 '마비카'를 뽑았다!");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                currentResult = ("'마비카'를 뽑았다!");
            }
            else if (randomValue <= 30)
            {
                currentResult = ("'나히다'를 뽑았다!");
            }
            else
            {
                currentResult = ("저런! 픽뚫로 '치치'가 나왔네요~");
            }
            allGachaResults += $"[{i + 1}회차] {currentResult}\n";
            count++;
        }
        outputText.text = allGachaResults;
    }
    /**
    public TMP_Text outputText;
    {
        if (outputText == null)
            {
            Debug.LogError("Output Text is not assigned in the inspector.");
            return;
        }
        int randomNum = Random.Range(1, 11);
        string GachaResult = "";
        
        switch(randomNum)
        {
            case 0:
                GachaResult = ("은색 머리 캐릭터가 나왔다!");
                break;
            case 1:
                GachaResult = ("금색 머리 캐릭터가 나왔다!");
                break;
            case 2:
                GachaResult = ("갈색 머리 캐릭터가 나왔다!");
                break;
            case 3:
                GachaResult = ("검은색 머리 캐릭터가 나왔다!");
                break;
            case 4:
                GachaResult = ("회색 머리 캐릭터가 나왔다!");
                break;
            case 5:
                GachaResult = ("초록색 머리 캐릭터가 나왔다!");
                break;
            case 6:
                GachaResult = ("파란색 머리 캐릭터가 나왔다!");
                break;
            case 7:
                GachaResult = ("보라색 머리 캐릭터가 나왔다!");
                break;
            case 8:
                GachaResult = ("핑크색 머리 캐릭터가 나왔다!");
                break;
            default:
                GachaResult = ("알 수 없는 머리 색 캐릭터가 나왔다!");
                break;
        }
        outputText.text = GachaResult;
    }
    **/
}
