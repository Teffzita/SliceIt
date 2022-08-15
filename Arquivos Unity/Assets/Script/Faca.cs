using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faca : MonoBehaviour
{

    public float vel = 1f;
    private Rigidbody2D rig;

    public GameObject GameOver;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * vel;

        }


    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.CompareTag("Borda"))
        {
            GameOver.SetActive(true);
            Time.timeScale = 0; //pausar o jogo
        }
    }
}
