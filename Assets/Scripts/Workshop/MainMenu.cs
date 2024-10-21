using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public void PlayGame() {


        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
            
        
    }

    public void QuitGame() {
        Application.Quit();
    }

     public void backButton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

     public void optionButton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    
}
