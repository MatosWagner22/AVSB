using System.Numerics;
using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{

    [SerializeField] UnityEngine.Vector3 Fuerza;
    [SerializeField] Sprite[] ballonSprites;
    [SerializeField] UIManager Manager;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    { 
        Manager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();

        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = ballonSprites[UnityEngine.Random.Range(0,4)];

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
            Manager.AddScore();
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        };

    }



}
