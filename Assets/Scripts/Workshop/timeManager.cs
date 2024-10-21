using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class timeManager : MonoBehaviour
{

    public Image healthBar;
    public Image text;
    public float healthAmount = 60.0f;
    public List<Sprite> spriteChoices;
    private float currentAmount = 60.0f;
    private int counter = 0;
    public bool ActivateTimer = false;
    public AudioSource musicSource;
    

    public AudioClip timeTheme;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.enabled = false;
        text.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

         if(ActivateTimer && healthAmount == 60.0f) {
            musicSource.Play();
            healthBar.enabled = true;
            text.enabled = true;
        }

        if(ActivateTimer) {
            healthAmount -= Time.deltaTime;
            
            
        }

       
        
        
        
        if(healthAmount + 10.0 <= currentAmount) {
            counter++;
            currentAmount = healthAmount;
            print(currentAmount);
            healthBar.sprite = spriteChoices[counter];
            if(counter == 7) {
                
            }
        } else {
            if(currentAmount <= 0) {
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
    }


}
