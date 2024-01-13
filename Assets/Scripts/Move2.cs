using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move2 : MonoBehaviour
{
    public int speed = 1;
    public bool moveforward = false;
    private bool key = false;
    public Text Line;
    // Start is called before the first frame update
    void Start()
    {
        Line.text = "FIND THE KEY"; 
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
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            key = true;
            other.gameObject.SetActive(false);
            Line.text = "GO TO THE DOOR";
        }
        if (other.gameObject.CompareTag("Gate") && key==true)
        {
            SceneManager.LoadScene("Jungle");
        }
    }
}
