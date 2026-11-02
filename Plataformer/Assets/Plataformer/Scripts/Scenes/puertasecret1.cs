using UnityEngine;

public class puertasecret1 : MonoBehaviour
{
    [SerializeField] private GameObject _puertasecret;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private bool _isOpen = false;
    [SerializeField] private Vector3 _secretoccordenadas;

    public void Llaveenmanosecret1()
    {
        _puertasecret.SetActive(true);
        _isOpen = true;
    }
    private void OnTriggerStay2D(Collider2D salida)
    {
        if (salida.gameObject.tag == "Player" && _isOpen == true)
        {
            _gameManager.Textodereferenciapuerta();

            if (Input.GetKey(KeyCode.Space))
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