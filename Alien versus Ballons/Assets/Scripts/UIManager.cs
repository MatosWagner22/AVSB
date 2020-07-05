using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    int score = 0;
    int objetivo = 20;
    [SerializeField] TextMeshProUGUI scoreText;

    public void AddScore(int s)
    {
        score+=s;
        scoreText.text = score.ToString();
    }

    public void Update()
    {
        if(score >= objetivo)
        {
            SceneManager.LoadScene("Final");
        }
    }
}
