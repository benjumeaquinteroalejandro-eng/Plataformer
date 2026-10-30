
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private Animator _animator;
    public int puntosVida = 100;
    public int escudoP = 0;
    public int puntos = 0;

    public void RestarVida(int daño)
    {
        puntosVida = puntosVida - daño;
    }
    public void OverHeal(int vida)
    {
        puntosVida = puntosVida + vida;
    }

    public void protector(int escudomas)
    {
        escudoP = escudoP + escudomas;

    }

    public void sinprotector(int destruido)
    {
        escudoP = escudoP - destruido;
    }

    public void paraganar(int secret)
    { 
        puntos = puntos + secret;
        _uiManager.actualizarpuntos(puntos);

        if (puntos >= 20)
        {
            _gameManager.Caminopuntos();
        }
        if (puntos >= 30)
        {
            _gameManager.Llavefinal();
        }
    }

    private void Update()
    {
        if (escudoP > 100)
        {
            escudoP = 100;
        }

        if (puntosVida >= 80 && escudoP == 0)
        {
            _uiManager.ColorBarra(Color.green);
        }
        if (puntosVida >= 40 && puntosVida < 80 && escudoP == 0)
        {
            _uiManager.ColorBarra(Color.yellow);
        }
        if (puntosVida >= 10 && puntosVida < 40 && escudoP == 0)
        {
            _uiManager.ColorBarra(Color.red);
        }
        if (puntosVida > 100 && escudoP == 0)
        {
            puntosVida = 100;
        }
        
        if (puntosVida <= 0)
        {
            _gameManager.PauseGame();
            _gameManager.Gameover();

        }
        
    }
}
