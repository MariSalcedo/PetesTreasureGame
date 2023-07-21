using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaHorizontal : MonoBehaviour
{
    public int tiempoVida;
    public float velMove;

    private void FixedUpdate()
    {
        // Para moverlo a la izquierda, la dirección debe ser negativa. Ej: -1 para ir al otro lado.
        transform.Translate(Vector2.right * Time.deltaTime * velMove);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, tiempoVida);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
