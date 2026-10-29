using UnityEngine;

public class Protector : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            if (_playerStats.escudoP < 100)
            {
                _playerStats.protector(20);

                _uiManager.SumarPFillAmount(0.2f);

                Destroy(this.gameObject);
            }
        }
    }
}
