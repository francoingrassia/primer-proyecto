using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int puntos = 0;
    public Vector3 coordenadas;
    private void Awake()
    {
        Debug.Log("Soy el Awake");
        coordenadas = new Vector3(1, 0, 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Soy el Start");

    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<SpriteRenderer>().flipY = true;
        //transform.position = coordenadas;

        //coordenadas = new Vector3(transform.position.x + 0.001f, transform.position.y + 0.001f, 0);
        //transform.Rotate(new Vector3(0, 0, -1));
    }
}
