using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "Player")
        {
            _gameManager.Win();
            _gameManager.PauseGame(); 
        }
    }
}
