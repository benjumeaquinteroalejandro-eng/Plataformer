using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _playerStats.RestarVida(100);
            _uiManager.RestarFillAmount(1F);
            
        }
    }
}
