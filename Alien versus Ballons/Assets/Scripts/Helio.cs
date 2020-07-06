using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Helio : MonoBehaviour
{
    [SerializeField] int helioInicial = 100;
    [SerializeField] int helioActual; 
    [SerializeField] Slider barraSlider;

// Start is called before the first frame update
    void Start()
    {
        FuntionTimer.Create(TomarDamage, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        helioActual = helioInicial;
    }
    
    public void TomarDamage()
    {
        helioActual -= 1;
        barraSlider.value = helioActual;
        if (helioActual <= 0){
            Destroy(this.gameObject);
            SceneManager.LoadScene("Final");
        }
    }

    public void SumarHelio(int h)
    {
        helioActual += h;
        barraSlider.value = helioActual;
    }
}
