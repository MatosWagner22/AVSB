using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Helio : MonoBehaviour
{
    int helioInicial = 100;
    int helioActual; 
    [SerializeField] Slider barraSlider;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        helioActual = helioInicial;
    }
    
    public void TomarDamage(int h)
    {
        helioActual -= h;
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
