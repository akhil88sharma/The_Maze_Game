using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Move : MonoBehaviour
{
    public int speed = 1;
    public bool moveforward = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            moveforward = !moveforward;
        }
        if (moveforward)
        {
            transform.position = transform.position + Camera.main.transform.forward*speed*Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Trophy"))
        {
            SceneManager.LoadScene("level 2");
        }
    }
}
