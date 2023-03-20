using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter (Collider other)
    {
        Debug.Log("F1");
      if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("F2");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
