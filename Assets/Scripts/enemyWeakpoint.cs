using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWeakpoint: MonoBehaviour
{
    public AudioClip deadMusic;
    [Range(0, 1)]
    public float volumeMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        AudioManager.instance.PlayAudio(deadMusic, volumeMusic);
        if (col.GetComponent<PlatformPlayer>())
        {

            Destroy(gameObject.transform.parent.gameObject);
            

        }
    }

}
   