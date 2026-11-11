using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int QuotaScore = 0;
    public int Score = 0;
    public int ComboScore = 0;
    public int Speed = 0;
    public int HighestCombo = 0;
    public int HighestSpeed = 0;

    public TextMeshProUGUI QuotaScoreField;
    public TextMeshProUGUI ScoreField;
    public TextMeshProUGUI ComboScoreField;
    public TextMeshProUGUI SpeedField;

    public TextMeshProUGUI HighestComboField;
    public TextMeshProUGUI HighestSpeedField;



    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if(ComboScore < HighestCombo)
        {
            HighestCombo = ComboScore;
        }
        if(Speed < HighestSpeed)
        {
            HighestSpeed = Speed;
        }
        UpdateUI();
    }

    public void UpdateUI()
    {
        QuotaScoreField.text = QuotaScore.ToString();
        ScoreField.text = Score.ToString();
        ComboScoreField.text = ComboScore.ToString();
        SpeedField.text = Speed.ToString();

        HighestComboField.text = HighestCombo.ToString();
        HighestSpeedField.text = HighestSpeed.ToString();
    }

}
