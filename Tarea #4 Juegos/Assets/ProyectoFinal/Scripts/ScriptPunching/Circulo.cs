using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}

