using UnityEngine;

public class Puertabanderas : MonoBehaviour
{
    [SerializeField] private GameManager _gamemanager;
    [SerializeField] private puertasecreto2 _conpuertas2;
    [SerializeField] private puertasecreto2 _conpuertasREVES2;
    private void OnTriggerStay2D(Collider2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _gamemanager.Textodereferenciapuerta();

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                _conpuertas2.Llaveenmanosecret2();
                _conpuertasREVES2.Llaveenmanosecret2();
                _gamemanager.conbanderapuerta();
                _gamemanager.armarlabandera();
                _gamemanager.Sinbanderaapagada();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D sal)
    {
        if (sal.gameObject.tag == "Player")
        {
            _gamemanager.Sintextopuerta();
        }
    }
}
