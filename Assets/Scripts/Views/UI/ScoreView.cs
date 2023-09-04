using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tmp;

    public void UpdateScore(string text, int score)
    {
        string finalText = text;
        finalText += score;
        tmp.text = finalText;
    }
}
