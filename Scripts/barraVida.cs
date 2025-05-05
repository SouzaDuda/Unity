using UnityEngine;
using UnityEngine.UI;
public class BarraVida : MonoBehaviour
{
    //[SerializeField] private float maxVida = 100;
    //[SerializeField] private Slider barraVida;
    [SerializeField] private float maxVida; //BarraVida j� cont�m uma defini��o de maxVida

    public HealthBar barraVida;
    private float vidaAtual;
    //private float maxVida; //BarraVida j� cont�m uma defini��o de maxVida, logo n�o � necess�rio sua declara��o

    private void Start()
    {
        vidaAtual = maxVida;
        barraVida.SetSliderMax(maxVida);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
