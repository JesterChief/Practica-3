using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateInGame : MonoBehaviour

{
    public TMPro.TMP_Text refresh;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        refresh.text = "punctuation " + GameManager.instance.GetPunt();
    }
}
