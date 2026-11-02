
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    [SerializeField] private Image _barra;
    [SerializeField] private Image _barrap;
    [SerializeField] private TextMeshProUGUI _puntosga;
    [SerializeField] private TextMeshProUGUI _temp;


    public void SumarFillAmount(float amount)
    {
        _barra.fillAmount += amount;

    }
    public void SumarPFillAmount(float amount)
    {
        _barrap.fillAmount += amount;
    }

    public void RestarFillAmount(float amount)
    { 
        _barra.fillAmount = _barra.fillAmount - amount;
    }
    public void RestarPFillAmount(float amount)
    {
        _barrap.fillAmount = _barrap.fillAmount - amount;
    }

    public void ColorBarra(Color color)
    {
        _barra.color = color;
        
        
    }
    public void actualizarpuntos(int puntosui)
    {
        _puntosga.text = Convert.ToString(puntosui);
    }
    public void actualizartime(int minutes, int sec)
    {
        _temp.text = string.Format("{0:00}:{1:00}", minutes, sec);
    }
}
