using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GachaManagerCleanUI : MonoBehaviour // ��ũ��Ʈ �̸� ����
{
    public TextMeshProUGUI Txt_Result;

    private string[] star3Characters = { "��Ű��" };
    private string[] star2Characters = { "���̾�", "�÷���*�׷�" };
    private string[] star1Characters = {"��ī��", "����(���̵�)", "��ī", "����(�巹��)", "�׷�(����)", "ȣ�ó�(����)", "�����(�巹��)"};
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
        int RandomNumber = Random.Range(0, 101);

        string drawnGrade = "";
        string finalDrawnCharacter = "";

        if (RandomNumber < 3)
        {
            drawnGrade = "�١١�";
            finalDrawnCharacter = star3Characters[Random.Range(0, star3Characters.Length)];
        }
        else if (RandomNumber < 21)
        {
            drawnGrade = "�١�";
            finalDrawnCharacter = star2Characters[Random.Range(0, star2Characters.Length)];
        }
        else
        {
            drawnGrade = "��";
            finalDrawnCharacter = star1Characters[Random.Range(0, star1Characters.Length)];
        }

        return finalDrawnCharacter + drawnGrade;
    }
}