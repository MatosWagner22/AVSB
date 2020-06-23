using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float yMinimo, yMaximo;
}
public class PlayerScript : MonoBehaviour
{
    public float speed;
    public Boundary boundary;
    float xPositionStart = 4.5f;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.position.x, Input.GetAxis("Vertical") * speed * Time.deltaTime, transform.position.z);

        float yPosition = Mathf.Clamp(transform.position.y, boundary.yMinimo , boundary.yMaximo);
        transform.position = new Vector3(0.0f, yPosition);
    }

}
