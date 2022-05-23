using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int puntos = 0;
    private void Awake()
    {
        Debug.Log("Soy el Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Soy el Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Soy el Update");
    }
}
