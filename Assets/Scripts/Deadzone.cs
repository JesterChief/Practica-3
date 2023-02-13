using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deadzone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {

            Destroy(col.gameObject);
            GameManager.instance.ChangeScene("GameOver");

        }
    }

// Update is called once per frame
void Update()
    {
        
    }
}
