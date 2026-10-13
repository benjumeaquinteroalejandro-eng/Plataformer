
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private Animator _animator;
    public int puntosVida = 100;

    public void RestarVida(int daño)
    {
        puntosVida = puntosVida - daño;
    }
    public void OverHeal(int vida)
    {
        puntosVida = puntosVida + vida;
    }

    private void Update()
    {
        if (puntosVida >= 80)
        {
            _uiManager.ColorBarra(Color.green);
        }
        if (puntosVida >= 40 && puntosVida < 80)
        {
            _uiManager.ColorBarra(Color.yellow);
        }
        if (puntosVida >= 10 && puntosVida < 40)
        {
            _uiManager.ColorBarra(Color.red);
        }
        if (puntosVida > 100)
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
