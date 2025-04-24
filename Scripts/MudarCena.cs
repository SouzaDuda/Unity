using UnityEngine.SceneManagement;
using UnityEngine;

public class MudarCena : MonoBehaviour
{
    public string nomeProximaFase;

    private void OnTriggerEnter(Collider collision)
    {
        IrProximaFase();
    }

    private void IrProximaFase()
    {
        SceneManager.LoadScene(this.nomeProximaFase);


    }
}