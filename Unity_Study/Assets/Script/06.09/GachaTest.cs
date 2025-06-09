using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GachaManagerCleanUI : MonoBehaviour // ��ũ��Ʈ �̸� ����
{
    public TextMeshProUGUI Txt_Result;

    private string[] star3Characters = { "��Ű��" };
    private string[] star2Characters = { "���̾�", "�÷���*�׷�" };
    private string[] star1Characters = {
        "��ī��", "����(���̵�)", "��ī", "����(�巹��)",
        "�׷�(����)", "ȣ�ó�(����)", "�����(�巹��)"
    };
    public void Gacha10x()
    {
        string allResultsText = "";
        List<string> current10DrawResults = new List<string>();

        for (int i = 0; i < 10; i++)
        {
            current10DrawResults.Add(DrawSingleGacha());
        }

        for (int i = 0; i < current10DrawResults.Count; i++)
        {
            allResultsText += $"[{i + 1}ȸ��] {current10DrawResults[i]}\n";
        }
        Txt_Result.text = allResultsText;
    }

    private string DrawSingleGacha()
    {
        float randomNumber = Random.Range(0.0f, 100.0f);

        string drawnGrade = "";
        string finalDrawnCharacter = "";

        if (randomNumber < 3.0f)
        {
            drawnGrade = "3��";
            finalDrawnCharacter = star3Characters[Random.Range(0, star3Characters.Length)];
        }
        else if (randomNumber < 21.0f)
        {
            drawnGrade = "2��";
            finalDrawnCharacter = star2Characters[Random.Range(0, star2Characters.Length)];
        }
        else
        {
            drawnGrade = "1��";
            finalDrawnCharacter = star1Characters[Random.Range(0, star1Characters.Length)];
        }

        return $"'{finalDrawnCharacter}' ({drawnGrade})�� �̾Ҵ�!";
    }
}