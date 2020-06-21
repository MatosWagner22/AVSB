using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon_Spawner : MonoBehaviour
{

    [SerializeField] GameObject ballonPreFab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",0.0f,.8f);
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
