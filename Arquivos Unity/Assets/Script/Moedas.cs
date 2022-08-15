using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas : MonoBehaviour
{
    public gamecontroller controller;

    void Start()
    {
        controller = FindObjectOfType<gamecontroller>();
    }
    
    void OnTriggerEnter2D(Collider2D colisor)
    {
        
        controller.moedas += 50;
        controller.moedatxt.text = controller.moedas.ToString();
    }
}
