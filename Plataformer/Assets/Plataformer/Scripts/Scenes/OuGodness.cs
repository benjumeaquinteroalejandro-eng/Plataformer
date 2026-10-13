using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuGodness : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            if (_playerStats.puntosVida < 100)
            {
                _playerStats.OverHeal(10);

                _uiManager.SumarFillAmount(0.1f);

                Destroy(this.gameObject);
            }
        }
    }
}
