using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject Bat;
    public AudioSource GrabSound;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            UiObject.SetActive(true);
        }
        
        
}
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(false);
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
            Destroy(Bat);
            UiObject.SetActive(false);
            GrabSound.Play();
        }
    }
    
}
