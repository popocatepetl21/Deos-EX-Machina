using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trollreset : MonoBehaviour
{
    [SerializeField] TMP_Text trollText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void troll()
    {
        trollText.enabled = true;
    }
}
