using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
