using UnityEngine;
using TMPro;

public class PlayerCollect : MonoBehaviour
{
    public int objetosRecolectados = 0;
    public TextMeshProUGUI textoObjetos;
    public GameObject pantallaGanaste;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            objetosRecolectados++;
            textoObjetos.text = "Objetos: " + objetosRecolectados;
            Destroy(other.gameObject);


            if (objetosRecolectados >= 10)
            {
                Ganar();
            }
        }
    }

    void Ganar()
    {

        pantallaGanaste.SetActive(true);


        Time.timeScale = 0f;
    }
}

