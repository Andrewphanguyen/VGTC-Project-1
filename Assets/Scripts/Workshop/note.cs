using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class note : MonoBehaviour
{


    [SerializeField]
    private GameObject pickUpText;
    public AudioSource paperSound;
    public AudioSource paperSound2;
    public GameObject note2;
    public timeManager script;



    private bool pickUpAllowed;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText.gameObject.SetActive(false);
        note2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (pickUpAllowed && Input.GetKeyDown(KeyCode.E)) {
            paperSound.Play();
            PickUp();
            
           
           
    } 

         if(Input.GetKeyDown(KeyCode.M)) {
                note2.SetActive(false);
                paperSound2.Play();
                script.ActivateTimer = true;
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
        
        note2.SetActive(true);
       
        
    }
}
