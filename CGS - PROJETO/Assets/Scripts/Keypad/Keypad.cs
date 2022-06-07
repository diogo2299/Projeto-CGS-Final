using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public AudioSource DoorOpen;
    public AudioSource WrongCode;

    public bool isVisible;

    [SerializeField]private Text Ans;
    [SerializeField] private Animator Door;

    private string Answer = "9246";
    public void Number(int number)
    {
       
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "CORRECT";
            DoorOpen.Play();
            Door.SetBool("Open", true);
            StartCoroutine("StopDoor");
           
            
        }
        else
        {
            Ans.text = "";
            WrongCode.Play();

        }
        
    }
    
    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Door.SetBool("Open", false);
        Door.enabled = false;
    }

    public void OpenKeyPad()
    {
        if (!isVisible)
        {
            isVisible = true;
            gameObject.SetActive(true);
            Debug.Log("funciona");
        }

    }

    
}
