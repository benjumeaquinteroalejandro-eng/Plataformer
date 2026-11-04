using UnityEngine;

public class puerta : MonoBehaviour
{
    [SerializeField] private GameObject _puerta;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private bool _isOpen = false;
    [SerializeField] private bool _havesecret = false;
    [SerializeField] private bool _havesecret2 = false;

    public void Llaveenmano()
    {
        _puerta.SetActive(true);
        _isOpen = true;
    }

    public void objetosecreto()
    {
        _havesecret = true;
    }
    public void objetosecreto2()
    {
        _havesecret2 = true;
    }

    private void OnTriggerStay2D(Collider2D salida)
    {
        if (salida.gameObject.tag == "Player" && _isOpen == true)
        {
            _gameManager.Textodereferenciapuerta();

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (_havesecret == false && _havesecret2 == false)
                {
                    _gameManager.Win();
                    _gameManager.PauseGame();
                }
                else if (_havesecret == true)
                {
                    _gameManager.Winsectret();
                    _gameManager.PauseGame();
                }
                if (_havesecret2 == true)
                {
                    _gameManager.Winsectret2();
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
