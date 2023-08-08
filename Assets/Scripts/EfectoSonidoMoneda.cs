using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoSonidoMoneda : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Si el objeto con el que est� colisionando tiene el tag de player, entonces destr�yelo.
        if (other.CompareTag("Player"))
        {
        audioSource.Play();
        }
    }
}