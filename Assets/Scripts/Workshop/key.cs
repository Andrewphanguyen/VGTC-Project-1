using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class key : MonoBehaviour {

    [SerializeField]
    private GameObject pickUpText;
    public AudioSource keySound;


    private bool pickUpAllowed;

	// Use this for initialization
	private void Start () {
        pickUpText.gameObject.SetActive(false);
        

	}
	
	// Update is called once per frame
	private void Update () {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E)) {
            keySound.Play();
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
        
    }

}
