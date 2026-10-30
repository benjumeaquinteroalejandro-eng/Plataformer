using UnityEngine;

public class puerta : MonoBehaviour
{
    [SerializeField] private GameObject _puerta;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private bool _isOpen = false;

    public void Llaveenmano()
    {
        _puerta.SetActive(true);
        _isOpen = true;
    }
    private void OnTriggerStay2D(Collider2D salida)
    {
        if (salida.gameObject.tag == "Player" && _isOpen == true)
        {
            _gameManager.Textodereferenciapuerta();

            if (Input.GetKey(KeyCode.Space))
            {
                _gameManager.Win();
                _gameManager.PauseGame();
            }
        }
    } 
}
