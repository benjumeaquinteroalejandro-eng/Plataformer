using UnityEngine;

public class puertasecreto2 : MonoBehaviour
{
    [SerializeField] private GameObject _puertasecret2;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private bool _isOpen = false;
    [SerializeField] private Vector3 _secretoccordenadas;

    public void Llaveenmanosecret2()
    {
        _puertasecret2.SetActive(true);
        _isOpen = true;
    }
    private void OnTriggerStay2D(Collider2D salida)
    {
        if (salida.gameObject.tag == "Player" && _isOpen == true)
        {
            _gameManager.Textodereferenciapuerta();

            if (Input.GetKey(KeyCode.S))
            {
                salida.transform.position = _secretoccordenadas;
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
