using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MonedaChica : MonoBehaviour
{
    //contador
    public float monedas;
    //texto para UI
    public TextMeshProUGUI NumMonedas;
    public GameObject MoneyS;

    private void OnCollisionEnter2D(Collision2D other)
    {
        //Al inicio del juego
        NumMonedas.text = "Doblones:" + monedas;

        if(other.gameObject.tag == "Player")
        {
            AgarrarMonedas();

        }
    }

    private void AgarrarMonedas()
    {
        monedas += 1;
        NumMonedas.text = "Doblones:" + monedas;
        Destroy(this.gameObject);
    }
    
}
