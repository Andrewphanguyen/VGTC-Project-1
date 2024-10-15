using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject heartPrefab;
      public DemoPlayerMovement DemoPlayerMovement;

    List<healthHeart> hearts = new List<healthHeart>();

    private void OnEnable() {
        DemoPlayerMovement.onPlayerDamaged += DrawHearts;
    }

    private void OnDisable() {
        DemoPlayerMovement.onPlayerDamaged -= DrawHearts;
    }

    private void Start() {
        DrawHearts();
    }

    public void DrawHearts() {
        ClearHearts();

        
        int heartsToMake = (int)(DemoPlayerMovement.maxHealth);
        for(int i = 0; i < heartsToMake; i++) {
            CreateEmptyHeart();
        }

        for(int i = 0; i < hearts.Count; i++) {
            int heartStatusRemainder = (int)Mathf.Clamp(DemoPlayerMovement.health - (i * 1), 0, 1);
            hearts[i].setHeartImage((HeartStatus)heartStatusRemainder);
        }
    }

    public void CreateEmptyHeart() {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        healthHeart heartComponent = newHeart.GetComponent<healthHeart>();
        heartComponent.setHeartImage(HeartStatus.Empty);
        hearts.Add(heartComponent);
    }

    public void ClearHearts() {
        foreach(Transform t in transform) {
            Destroy(t.gameObject);
        }
        hearts = new List<healthHeart>();
    }
   
}
