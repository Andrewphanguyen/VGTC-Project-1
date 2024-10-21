using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class audioManager : MonoBehaviour
{
    public static audioManager instance;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource musicSource2;
    [SerializeField] AudioSource musicSource3;

    public GameObject ObjectMusic;
    public Slider musicSlider;
    public AudioClip trainSound;
    public AudioClip menuSong;
    public AudioClip overMusic;
    
    private void Start() {
        
        
        
        
    
      
    }

    public void PlaySFX(AudioClip clip) {
        
         SFXSource.PlayOneShot(clip);
    
      
    }

    
     public void Update() {
        
        //musicSource.volume = musicSlider.value;

         Scene currentScene = SceneManager.GetActiveScene();

    if (currentScene.name == "DemoLevel")
    {
        
         musicSource2.clip = trainSound;
        
    }

    if (currentScene.name == "gameOver")
    {
        
         musicSource3.clip = overMusic;
        
    }
   
    
        
    }

    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(instance);
        } else if(currentScene.name == "DemoLevel") {
            DontDestroyOnLoad(instance);
        }
           
        else
        {
            Destroy(gameObject);
        }
    }

    

    
    
}
