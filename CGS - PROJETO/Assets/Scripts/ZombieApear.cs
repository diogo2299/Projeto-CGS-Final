using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieApear : MonoBehaviour
{
    public GameObject zombie;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        zombie.SetActive(true);
    }
}
