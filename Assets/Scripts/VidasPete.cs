using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasPete : MonoBehaviour
{
    public GameObject[] VIDAS;
    public int vidas = 5;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           DanoVIDA();
            vidas--;
            if (vidas < 1)
            {
                Destroy(VIDAS[0].gameObject);
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    private void DanoVIDA()
    {
        vidas--;
        if (vidas < 5)
        {
            Destroy(VIDAS[4].gameObject);
        }
    }
}