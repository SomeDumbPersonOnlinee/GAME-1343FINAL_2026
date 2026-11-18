using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

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

    bool pause = false;


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

    public void GetInput()
    {
        Keyboard kb = Keyboard.current;

        pause = kb.pKey.wasPressedThisFrame;
    }

    public void getProjectileValues(int pTotal, int sMAX, int cMAX, int sped, int comb)
    {
        Score = pTotal;
        HighestCombo = cMAX;
        HighestSpeed = sMAX;
        Speed = sped;
        ComboScore = comb;
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
