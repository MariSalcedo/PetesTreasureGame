using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoVida : MonoBehaviour
{
    // Referencia
    public GameManager pv;

    //Colision
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pv.PerderVIDA();
        }
    }

}
