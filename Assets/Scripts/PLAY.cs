using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Playgame()
    {
        SceneManager.LoadScene("level 1");
    }
    public void Exitgame()
    {
        Application.Quit();
    }
}
