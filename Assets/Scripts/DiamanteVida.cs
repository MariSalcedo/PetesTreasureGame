using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamanteVida : MonoBehaviour
{

    public GameManager gm;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            bool vidanueva = gm.NuevaVida();

            if(vidanueva)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
