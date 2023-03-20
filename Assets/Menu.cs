using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Hra");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void quit()
    {
        Application.Quit();
    }
}
