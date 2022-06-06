using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource ButtonSound;
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
        ButtonSound.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("GameQuit");
    }
}