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
    public pauseMenu ps;
    public timeManager noteMusic;
    public bool hasPlayed = false;
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
        //SFXSource.mute = false;
        hasPlayed = true;
        
    }

    if (currentScene.name == "gameOver")
    {
         musicSource.mute = true;
         musicSource3.clip = overMusic;
        
    } 

    if(currentScene.name == "MainMenu" && hasPlayed) {
        SFXSource.mute = true;
        musicSource.clip = menuSong;
        musicSource.mute = false;
        
    }

    

    if(ps.GameIsPaused && currentScene.name == "DemoLevel") {
        SFXSource.mute = true;
        noteMusic.musicSource.mute = true;
    } else {
        SFXSource.mute = false;
        noteMusic.musicSource.mute = false;
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
        } else if(currentScene.name == "gameOver") {
            
            DontDestroyOnLoad(instance);
        } 
           
        else
        {
            Destroy(gameObject);
        }
    }

    

    
    
}
