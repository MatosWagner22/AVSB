﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    [SerializeField] UnityEngine.Vector3 Fuerza;
    [SerializeField] Sprite[] ballonSprites;
    [SerializeField] UIManager Manager;
    [SerializeField] SoundManager sound;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    { 
        Manager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        sound = GameObject.FindGameObjectWithTag("Pop").GetComponent<SoundManager>();
        
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = ballonSprites[UnityEngine.Random.Range(0,1)];

        transform.position = new UnityEngine.Vector3(UnityEngine.Random.Range(-0.301f, 0.451f), transform.position.y,transform.position.z);

        Fuerza = new UnityEngine.Vector3(UnityEngine.Random.Range(-100,100),UnityEngine.Random.Range(150,250));
        rb.AddForce(Fuerza);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag=="Pared0"){

            Destroy(this.gameObject);

        }else if(other.gameObject.tag=="Laser")
        {
            sound.PlaySound();
            Destroy(this.gameObject,0.1f);
            Destroy(other.gameObject);
            Manager.AddScore(10);
        }
    }
}
