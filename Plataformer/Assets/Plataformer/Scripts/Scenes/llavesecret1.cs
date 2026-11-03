
using UnityEngine;

public class llavesecret1 : MonoBehaviour
{
    [SerializeField] private GameManager _gamemanager;
    [SerializeField] private puertasecreto _conpuertas1;
    [SerializeField] private puertasecreto _conpuertasREVES;
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
