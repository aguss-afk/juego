using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("nivel 1");
    }
     public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit(); 
    }
}
