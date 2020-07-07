using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Spawner : MonoBehaviour
{
    [SerializeField] GameObject ballonPreFab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",0.0f,5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(ballonPreFab, transform.position, transform.rotation);
    }
}
