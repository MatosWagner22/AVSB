using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Helio : MonoBehaviour
{
    float helioInicial = 100;
    float helioActual; 
    float maxTime = 200f; 
    [SerializeField] Slider barraSlider;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        TomarDamage();
    }

    private void Awake()
    {
        helioActual = helioInicial;
    }
    
    public void TomarDamage()
    {
        helioActual -= Time.deltaTime;
        barraSlider.value = (helioActual/maxTime);
        if (helioActual <= 0){
            Destroy(this.gameObject);
            SceneManager.LoadScene("Final");
        }
    }

    public void SumarHelio(int h)
    {
        helioActual += (h/2);
        barraSlider.value = helioActual;
    }
}
