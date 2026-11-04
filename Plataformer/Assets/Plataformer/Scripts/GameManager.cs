using System.Security.Cryptography;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject _gameover;
    [SerializeField] private GameObject _win;
    [SerializeField] private GameObject _winsecret;
    [SerializeField] private GameObject _winsecret2;
    [SerializeField] private GameObject _puntoSecret;
    [SerializeField] private GameObject _puntoCerrado;
    [SerializeField] private GameObject _puntoSecret2;
    [SerializeField] private GameObject _llaveSalida;
    [SerializeField] private GameObject _llaveamarilla;
    [SerializeField] private GameObject _space;
    [SerializeField] private GameObject _llaveazul;
    [SerializeField] private GameObject _objsecret1;
    [SerializeField] private GameObject _objsecret2;
    [SerializeField] private GameObject _finalbanderas;
    [SerializeField] private GameObject _llavenaranja;
    [SerializeField] private GameObject _banderaamarilla;
    [SerializeField] private GameObject _labandera;
    [SerializeField] private GameObject _banderaapagada;
    [SerializeField] private GameObject _banderaspuntos;
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
    public void Winsectret()
    {
        _winsecret.SetActive(true);
    }
    public void Winsectret2()
    {
        _winsecret2.SetActive(true);
    }
    public void Caminopuntos()
    {
        _puntoSecret.SetActive(false);
    }
    public void AbrirCaminocerrado()
    {
        _puntoCerrado.SetActive(false);
    }
    public void Caminopuntos2()
    {
        _puntoSecret2.SetActive(false);
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
    public void Sintextopuerta()
    {
        _space.SetActive(false);
    }
    public void activarbasicasbanderas()
    {
        _banderaspuntos.gameObject.SetActive(true);

    }
    public void conLlaveazul()
    {
        _llaveazul.SetActive(true);
    }
    public void conLlavenaranja()
    {
        _llavenaranja.SetActive(true);
    }
    public void conbanderapuerta()
    {
        _banderaamarilla.SetActive(true);
    }
    public void armarlabandera()
    {
        _labandera.SetActive(true);
    }
    public void Sinbanderaapagada()
    {
        _banderaapagada.SetActive(false);
    }
    public void conobjsecret1()
    {
        _objsecret1.SetActive(true);
    }
    public void conobjsecret2()
    {
        _objsecret2.SetActive(true);
    }
    public void ultimabandera()
    {
        _finalbanderas.SetActive(true);
    }
}
