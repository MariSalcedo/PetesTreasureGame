using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCambiarEscena : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnApplicationQuit()
    {
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}