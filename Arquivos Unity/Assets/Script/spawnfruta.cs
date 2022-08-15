using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnfruta : MonoBehaviour
{
    public GameObject fruta;
    public float maxT;

    private float tempo = 0f;


    // Start is called before the first frame update
    void Start()
    {
        GameObject newfruta = Instantiate(fruta);
        newfruta.transform.position = transform.position + new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo > maxT)
        {
            GameObject newfruta = Instantiate(fruta);
            newfruta.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(newfruta, 20f);
            tempo = 0;
        }

        tempo += Time.deltaTime;
    }
}
