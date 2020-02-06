using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrado : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }

    void Update()
    {
    }


}
