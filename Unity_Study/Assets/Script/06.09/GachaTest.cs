using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GachaManagerCleanUI : MonoBehaviour // 스크립트 이름 변경
{
    public TextMeshProUGUI Txt_Result;

    private string[] star3Characters = { "아키라" };
    private string[] star2Characters = { "세이아", "시로코*테러" };
    private string[] star1Characters = {
        "와카모", "마리(아이돌)", "미카", "히나(드레스)",
        "네루(교복)", "호시노(무장)", "사오리(드레스)"
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
            allResultsText += $"[{i + 1}회차] {current10DrawResults[i]}\n";
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
            drawnGrade = "3성";
            finalDrawnCharacter = star3Characters[Random.Range(0, star3Characters.Length)];
        }
        else if (randomNumber < 21.0f)
        {
            drawnGrade = "2성";
            finalDrawnCharacter = star2Characters[Random.Range(0, star2Characters.Length)];
        }
        else
        {
            drawnGrade = "1성";
            finalDrawnCharacter = star1Characters[Random.Range(0, star1Characters.Length)];
        }

        return $"'{finalDrawnCharacter}' ({drawnGrade})을 뽑았다!";
    }
}