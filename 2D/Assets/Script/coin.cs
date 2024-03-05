using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int valor = 1;
    public GameObject gameManager;
    public AudioClip sonidoMoneda;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameManager.GetComponent<GameManager>().SumarPuntos(valor);
            Destroy(gameObject); // Destruir la moneda actual (this.gameObject)
            AudioManager.Instance.ReproducirSonido(sonidoMoneda);
        }
    }
}
