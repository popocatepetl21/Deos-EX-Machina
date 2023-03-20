using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EnemyDestroyer : MonoBehaviour
{
    [SerializeField] public TMP_Text body;
    [SerializeField] public TMP_Text highscores;
    int score = 0;
    int highscore = 0;
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highs");
        highscores.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        body.text = score.ToString();
        HighScoreCheck();
        HighScoreReset();
    }
    void OnTriggerEnter (Collider other)
    {
        Destroy(other.gameObject);
        score++;

    }

    void HighScoreCheck()
    {
        if(score >= highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highs", highscore);
            highscores.text = highscore.ToString();
        }
    }

    void HighScoreReset()
    {
        if(Input.GetKeyDown(KeyCode.RightControl))
        {
            highscore = 0;
            PlayerPrefs.SetInt("highs", highscore);
        }
    }
}
