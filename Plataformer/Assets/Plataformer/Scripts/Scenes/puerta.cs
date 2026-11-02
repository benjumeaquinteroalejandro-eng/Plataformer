using UnityEngine;

public class puerta : MonoBehaviour
{
    [SerializeField] private GameObject _puerta;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private bool _isOpen = false;
    [SerializeField] private bool _havesecret = false;

    public void Llaveenmano()
    {
        _puerta.SetActive(true);
        _isOpen = true;
    }

    public void objetosecreto()
    {
        _havesecret = true;
    }

    private void OnTriggerStay2D(Collider2D salida)
    {
        if (salida.gameObject.tag == "Player" && _isOpen == true)
        {
            _gameManager.Textodereferenciapuerta();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_havesecret == false)
                {
                    _gameManager.Win();
                    _gameManager.PauseGame();
                }
                else if (_havesecret == true)
                {
                    _gameManager.Winsectret();
                    _gameManager.PauseGame();
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D nosalida)
    {
        if (nosalida.gameObject.tag == "Player" && _isOpen == true)
        {
            _gameManager.Sintextopuerta();
        }
    }
}
