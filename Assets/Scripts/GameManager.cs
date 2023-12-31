using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager obj;
    [Header("textoMonedas")]

    public TextMeshProUGUI textoMoneda;

    //Variables
    public GameObject[] BarraVIDAS;
    private int LimiteVidas = 5;

    // Metodos

    private void Awake()
    {
        obj = this;
    }
    public void DesactivarVIDA(int Indice)
    {
        BarraVIDAS[Indice].SetActive(false);
    }

    public void ActivarVIDA(int Indice)
    {
        BarraVIDAS[Indice].SetActive(true);
    }

    public void PerderVIDA()
    {
        LimiteVidas -= 1;
        if (LimiteVidas == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        DesactivarVIDA(LimiteVidas);
    }

    public bool NuevaVida()
    {
        if (LimiteVidas == 5)
        {
            return false;
        }
        ActivarVIDA(LimiteVidas);
        LimiteVidas += 1;
        return true;
    }
}
