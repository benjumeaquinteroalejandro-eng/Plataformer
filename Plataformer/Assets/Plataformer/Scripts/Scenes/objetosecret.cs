using UnityEngine;

public class objetosecret : MonoBehaviour
{
    [SerializeField] private GameManager _gamemanager;
    [SerializeField] private puerta _parafinal;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _parafinal.objetosecreto();
            _gamemanager.conobjsecret1();

            Destroy(this.gameObject);
        }
    }
}
