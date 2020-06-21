using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{

    [SerializeField] Vector3 Fuerza;
    [SerializeField] Sprite[] ballonSprites;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = ballonSprites[UnityEngine.Random.Range(0,4)];

        Fuerza = new Vector3(UnityEngine.Random.Range(-100,100),UnityEngine.Random.Range(150,250));
        rb.AddForce(Fuerza);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
