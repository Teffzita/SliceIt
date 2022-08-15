using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlat : MonoBehaviour
{
    public GameObject plataformas;
    public float maxT;

    private float tempo = 0f;


    // Start is called before the first frame update
    void Start()
    {
        GameObject newplat = Instantiate(plataformas);
        newplat.transform.position = transform.position + new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(tempo > maxT)
        {
            GameObject newplat = Instantiate(plataformas);
            newplat.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(newplat, 20f);
            tempo = 0;
        }

        tempo += Time.deltaTime;
    }
}
