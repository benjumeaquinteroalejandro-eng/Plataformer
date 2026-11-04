using UnityEngine;

public class objetosecret2 : MonoBehaviour
{
    [SerializeField] private GameManager _gamemanager;
    [SerializeField] private puerta _parahyperfinal;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _parahyperfinal.objetosecreto2();
            _gamemanager.conobjsecret2();

            Destroy(this.gameObject);
        }
    }
}
