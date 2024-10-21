using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{

     [SerializeField]
    private GameObject pickUpText;
    public AudioSource paperSound;
    public AudioSource paperSound2;
    public GameObject note2;
    
    public key keyy;


    private bool pickUpAllowed;

    void Start()
    {
        pickUpText.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
         if (pickUpAllowed && Input.GetKeyDown(KeyCode.E) && keyy.hasKey) {
            paperSound.Play();
            PickUp();
            
    } 

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        
        Destroy(gameObject);
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
