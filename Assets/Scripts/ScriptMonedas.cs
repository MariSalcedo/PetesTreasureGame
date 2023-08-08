using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMonedas : MonoBehaviour
{
    [SerializeField] private int valorMoneda;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ControlJugador.obj.monedas++;
            GameManager.obj.textoMoneda.text = (ControlJugador.obj.monedas.ToString());
            Destroy(this.gameObject);
        }
    }   
}