using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("Awake2");

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Awake3");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.position.x, Input.GetAxis("Vertical") * speed * Time.deltaTime, transform.position.z);
    }

    private void OnDisable()
    {
        Debug.Log("Awake4");

    }

    private void OnDestroy()
    {
        Debug.Log("Awake5");

    }

}
