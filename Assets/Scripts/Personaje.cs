using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public Vector3 coordenadas;
    public float velocidad = 0.03f;
    public int velodicadR = 1;
    public float escala = 0.01f;
    private void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + velocidad, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + velocidad, transform.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x + velocidad * -1, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + velocidad * -1, transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, velodicadR * -1));
            transform.localScale = new Vector3(transform.localScale.x + escala, transform.localScale.y + escala, transform.localScale.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, velodicadR));
            if (transform.localScale.x >= 0)
            {
                transform.localScale = new Vector3(transform.localScale.x + escala * -1, transform.localScale.y + escala * -1, transform.localScale.z);
            }
        }
    }
}
