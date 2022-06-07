using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{
    public NavMeshAgent Agent;
    public bool Seguir;
    public float WaitTime;
    public AudioSource ZombieSound;

    Animator animator;

    
  //  public Transform VisaoLocal;
 //   public LayerMask Layoso; 
 //   private Vector3 LastPos;


    private void Start()
    {
       
        
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        animator.SetFloat("Move", Mathf.Abs(Agent.velocity.magnitude));

        if (Seguir == true)
        {
            WaitTime = 0;
            ZombieSound.Play();
        }
        else
        {
            if (WaitTime <= 2)
                WaitTime += 1 * Time.deltaTime;
            if (Agent.destination != transform.position)
                Agent.destination = transform.position;
        }

        if (WaitTime <= 2)
        {

                    Agent.destination = GameObject.FindWithTag("Player").transform.position;

            
        }


    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            SceneManager.LoadScene("GAMEOVER");
            Cursor.visible = true;
            Screen.lockCursor = false;
        }
    }


}
