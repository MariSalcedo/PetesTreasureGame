using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirEnemigo : MonoBehaviour
{
    public AudioSource audioEliminarPajaro;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el objeto con el que está colisionando tiene el tag de player, entonces destrúyelo.
        if (collision.gameObject.tag == "Player")
        {
            audioEliminarPajaro.Play();
            Destroy(transform.parent.parent.gameObject);
        }
    }
}