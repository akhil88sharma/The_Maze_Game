using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move3 : MonoBehaviour
{
    public int speed = 1;
    public bool moveforward = false;
    public GameObject mushroom;
    public Text line;
    public Text count;
    private int r = 0;
    private int p = 0;
    public GameObject rocks,cm;
    public AudioSource asource;
    public AudioClip aclip;


    // Start is called before the first frame update
    void Start()
    {
        mushroom.SetActive(false);
        line.text = "WELCOME TO JUNGLE \nCAN YOU ESCAPE?";
        count.text = "";
        cm.SetActive(false);

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

        if (other.gameObject.CompareTag("Monster"))
        {
            line.text = "FIND FIVE MUSHROOMS....RAAARRGGG \n(THREE RED , TWO PURPLE)";
            line.color = Color.green;
           
            mushroom.SetActive(true);
            moveforward = false;
            count.text = "Red Mushrooms :" + r + "\nPurple Mushrooms :" + p;
        }

        if (other.gameObject.CompareTag("PM"))
        {
            p = p + 1;
            count.text = "Red Mushrooms :" + r + "\nPurple Mushrooms :" + p;
            other.gameObject.SetActive(false);
            asource.PlayOneShot(aclip);

        }

        if (other.gameObject.CompareTag("RM"))
        {
            r = r + 1;
            count.text = "Red Mushrooms :" + r + "\nPurple Mushrooms :" + p;
            other.gameObject.SetActive(false);
            asource.PlayOneShot(aclip);
        }

        if (r>=5&&p==2)
        {
            line.text = "GO BACK TO THE TROLL";
            line.color = Color.yellow;
        }

        if (other.gameObject.CompareTag("Monster")&&(r>=5&&p==2))
        {
            count.text = "";
            line.text = "AM I THE STRONGEST MONSTER ?....RRGGRRGGGG\n(TRUE OR FALSE)";
            line.color = Color.green;
            rocks.SetActive(false);
            cm.SetActive(true);
        }

        if(other.gameObject.CompareTag("TG"))
        {
            SceneManager.LoadScene("EndScene");
        }

        if (other.gameObject.CompareTag("FG"))
        {
            SceneManager.LoadScene("Jungle");
        }
    }
}
