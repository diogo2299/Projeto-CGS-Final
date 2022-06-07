using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieApear : MonoBehaviour
{
    public GameObject zombie;
   // public AudioSource ZombieSound;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        zombie.SetActive(true);
      //  ZombieSound.Play();
    }
}
