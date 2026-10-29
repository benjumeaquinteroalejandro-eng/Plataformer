using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            if(_playerStats.escudoP == 0)
            {
                _playerStats.RestarVida(10);
                _uiManager.RestarFillAmount(0.1F);
            }
            else
            {
                _playerStats.sinprotector(20);
                _uiManager.RestarPFillAmount(0.2F);
            }
        }
    }
}
