using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector2 nuevaPos;
    public GameObject prefabACrear;
    public float intervaloParaCrear = 5;
    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= intervaloParaCrear)
        {
            GameObject nuevoObjeto = Instantiate(prefabACrear);
            Vector2 posFinal = nuevaPos;
            posFinal = (Vector2)transform.position + nuevaPos;
            nuevoObjeto.transform.position = posFinal;
            timer -= intervaloParaCrear;
        }
    }
}