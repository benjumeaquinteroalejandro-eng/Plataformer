using System.Security.Cryptography;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject _gameover;
    [SerializeField] private GameObject _win;
    [SerializeField] private GameObject _puntoSecret;
    [SerializeField] private GameObject _llaveSalida;
    [SerializeField] private GameObject _llaveamarilla;
    [SerializeField] private GameObject _space;


    public void Start()
    {
        Time.timeScale = 1;
    }
    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    public void Gameover()
    {
        _gameover.SetActive(true);
    }
    public void Win()
    {
        _win.SetActive(true);
    }
    public void Caminopuntos()
    {
        _puntoSecret.SetActive(false);
    }
    public void Llavefinal()
    {
        _llaveSalida.SetActive(true);
    }
    public void conLlaveamarilla()
    { 
        _llaveamarilla.SetActive(true);
    }
    public void Textodereferenciapuerta()
    { 
        _space.SetActive(true);
    }
}
