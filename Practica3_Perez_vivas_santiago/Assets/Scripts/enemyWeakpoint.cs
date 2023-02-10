using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWeakpoint: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.GetComponent<PlatformPlayer>())
        {

            Destroy(gameObject.transform.parent.gameObject);
            

        }
    }

}
    //private void OnCollisionEnter2D(Collision2D other)

    //{


        //if (other.collider.GetComponent<PlatformPlayer>())
        //{



            //Destroy(other.gameObject);
            
        //}


    //}

    // Update is called once per frame
   
