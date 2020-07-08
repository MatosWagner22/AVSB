using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    int score = 0;
    int objetivo = 500;
    [SerializeField] TextMeshProUGUI scoreText;
    //------------------------------------------------------------------------------------------------------------------------------------------
    float helioActual; 
    float maxTime = 50f; 
    [SerializeField] Image Helio;
    //------------------------------------------------------------------------------------------------------------------------------------------
    public void AddScore(int s)
    {
        SumarHelio(s);
        score+=s;
        scoreText.text = score.ToString();
    }

    public void Update()
    {
        if(score >= objetivo)
        {
            SceneManager.LoadScene("Final");
        }

        TomarDamage();
    }
    //------------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        helioActual = maxTime;
    }
    
    public void TomarDamage()
    {
        
        if (helioActual > 0){
            helioActual -= Time.deltaTime;
            Helio.fillAmount = (helioActual/maxTime);
        }else
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Final");
        }
    }

    public void SumarHelio(int h)
    {
        helioActual += (h/2);
        Helio.fillAmount  = helioActual;
    }
}
