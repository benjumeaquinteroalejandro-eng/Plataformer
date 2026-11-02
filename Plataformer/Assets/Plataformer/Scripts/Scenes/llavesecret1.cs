
using UnityEngine;

public class llavesecret1 : MonoBehaviour
{
    [SerializeField] private GameManager _gamemanager;
    [SerializeField] private puertasecret1 _conpuertas1;
    [SerializeField] private puertasecret1 _conpuertasREVES;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _conpuertas1.Llaveenmanosecret1();
            _conpuertasREVES.Llaveenmanosecret1();
            _gamemanager.conLlaveazul();

            Destroy(this.gameObject);
        }
    }
}
