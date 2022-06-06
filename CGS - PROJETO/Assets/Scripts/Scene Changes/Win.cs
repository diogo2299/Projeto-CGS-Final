using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public AudioSource ButtonSound;
    // Start is called before the first frame update
    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
        ButtonSound.Play();
        Cursor.visible = true;
        Screen.lockCursor = false;
    }

    
}