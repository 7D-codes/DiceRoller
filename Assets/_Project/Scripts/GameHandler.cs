using UnityEngine;
using TMPro;

public class GameHandler : MonoBehaviour
{
    int score;
    [SerializeField]
    private Dice dice;
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    [SerializeField]
    private float SpawnHight = 16f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dice, new Vector3(0, SpawnHight, 0), Quaternion.identity);
        }
    }

    public void Addscore(int point)
    {
        score += point;
        ScoreText.text = score.ToString();
    }
}
