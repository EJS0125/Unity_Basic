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
            Debug.Log($"���� ��:  {randomValue} �Դϴ�");
            if (8 <= count)
            {
                currentResult = ("Ȯ������ '����ī'�� �̾Ҵ�!");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                currentResult = ("'����ī'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30)
            {
                currentResult = ("'������'�� �̾Ҵ�!");
            }
            else
            {
                currentResult = ("����! �ȶշ� 'ġġ'�� ���Գ׿�~");
            }
            allGachaResults += $"[{i + 1}ȸ��] {currentResult}\n";
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
                GachaResult = ("���� �Ӹ� ĳ���Ͱ� ���Դ�!");
                break;
            case 1:
                GachaResult = ("�ݻ� �Ӹ� ĳ���Ͱ� ���Դ�!");
                break;
            case 2:
                GachaResult = ("���� �Ӹ� ĳ���Ͱ� ���Դ�!");
                break;
            case 3:
                GachaResult = ("������ �Ӹ� ĳ���Ͱ� ���Դ�!");
                break;
            case 4:
                GachaResult = ("ȸ�� �Ӹ� ĳ���Ͱ� ���Դ�!");
                break;
            case 5:
                GachaResult = ("�ʷϻ� �Ӹ� ĳ���Ͱ� ���Դ�!");
                break;
            case 6:
                GachaResult = ("�Ķ��� �Ӹ� ĳ���Ͱ� ���Դ�!");
                break;
            case 7:
                GachaResult = ("����� �Ӹ� ĳ���Ͱ� ���Դ�!");
                break;
            case 8:
                GachaResult = ("��ũ�� �Ӹ� ĳ���Ͱ� ���Դ�!");
                break;
            default:
                GachaResult = ("�� �� ���� �Ӹ� �� ĳ���Ͱ� ���Դ�!");
                break;
        }
        outputText.text = GachaResult;
    }
    **/
}
