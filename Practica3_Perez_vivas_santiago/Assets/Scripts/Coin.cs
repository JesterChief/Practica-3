using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int punctuation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Al pasar por encima de la moneda se destruya
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.AddPunt(punctuation);
            Destroy(this.gameObject);
        }
    }
}
