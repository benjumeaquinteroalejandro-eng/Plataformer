
using UnityEngine;

public class temporizador : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private float _temporizado = 530f;

    void Update()
    {
        if (_temporizado > 0)
        {
            _temporizado -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(_temporizado / 60);
            int sec = Mathf.FloorToInt(_temporizado % 60);

            _uiManager.actualizartime(minutes, sec);
        }
        else
        {
            _uiManager.actualizartime(0, 0);
            _gameManager.Gameover();
            _gameManager.PauseGame();
        }
    }
}
