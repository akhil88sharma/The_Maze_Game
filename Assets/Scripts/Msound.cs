using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Msound : MonoBehaviour
{
    AudioSource msound;
    // Start is called before the first frame update
    void Start()
    {
        msound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("CAM"))
        {
            msound.Play();
        }
    }
}
