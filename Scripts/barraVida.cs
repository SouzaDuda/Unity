using UnityEngine;
using UnityEngine.UI;
public class BarraVida : MonoBehaviour
{
    //[SerializeField] private float maxVida = 100;
    //[SerializeField] private Slider barraVida;
    [SerializeField] private float maxVida; //BarraVida já contém uma definição de maxVida

    public HealthBar barraVida;
    private float vidaAtual;
    //private float maxVida; //BarraVida já contém uma definição de maxVida, logo não é necessário sua declaração

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
