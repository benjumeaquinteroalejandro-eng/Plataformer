using UnityEngine;

public class Puntosbanderas : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private bool _isThere = false;

    
    public void tenerpuntosbanderas()
    {
        _isThere = true;
    }
    private void OnTriggerStay2D(Collider2D colision)
    {

        if (colision.gameObject.tag == "Player" && _isThere == true)
        {
            _gameManager.Textodereferenciapuerta();

            if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("presioné la tecla");
                _playerStats.paraganar(10);

                Destroy(this.gameObject);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D exit)
    {
        if (exit.gameObject.tag == "Player" && _isThere == true)
        {
            _gameManager.Sintextopuerta();
        }
    }
}
