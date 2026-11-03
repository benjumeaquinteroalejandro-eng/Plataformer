using UnityEngine;

public class llavesecret2 : MonoBehaviour
{
    [SerializeField] private GameManager _gamemanager;
    [SerializeField] private GameObject _flagsfather;
    
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            Puntosbanderas[] HijosBanderas = _flagsfather.GetComponentsInChildren<Puntosbanderas>();
            foreach (Puntosbanderas bandera in HijosBanderas)
            {
                bandera.tenerpuntosbanderas();
            }
            _gamemanager.activarbasicasbanderas();
            _gamemanager.conLlavenaranja();

            Destroy(this.gameObject);
        }
    }
}
