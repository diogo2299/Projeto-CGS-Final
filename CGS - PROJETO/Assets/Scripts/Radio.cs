using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public GameObject Message;
    public GameObject Rad;
    public AudioSource Place;
    public GameObject battery;
    // Start is called before the first frame update
    void Start()
    {
        Message.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && battery.gameObject == null)
        {
            Message.SetActive(true);
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Message.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            Message.SetActive(false);
            Place.Play();
        }
    }

}
