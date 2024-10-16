using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeManager : MonoBehaviour
{

    public Image healthBar;
    public float healthAmount = 60.0f;
    public List<Sprite> spriteChoices;
    private float currentAmount = 60.0f;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthAmount -= Time.deltaTime;
        
        
        if(healthAmount + 10.0 <= currentAmount) {
            counter++;
            currentAmount = healthAmount;
            print(currentAmount);
            healthBar.sprite = spriteChoices[counter];
            if(counter == 3) {
                counter = -1;
            }
        }
    }


}
