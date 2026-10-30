using UnityEngine;

public class llavepuerta : MonoBehaviour
{
    [SerializeField] private GameManager _gamemanager;
    [SerializeField] private puerta _conpuerta;
    [SerializeField] private GameObject _llave;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _conpuerta.Llaveenmano();
            _gamemanager.conLlaveamarilla();

            Destroy(this.gameObject);
        }
    }
}
