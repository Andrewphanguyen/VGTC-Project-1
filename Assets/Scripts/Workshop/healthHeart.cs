using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthHeart : MonoBehaviour
{
    public Sprite fullHeart;
    public Sprite emptyHeart;
    Image heartImage;

    private void Awake() {
        heartImage = GetComponent<Image>();
    }

    
    public void setHeartImage(HeartStatus status) {
        switch(status) {
            case HeartStatus.Empty:
                heartImage.sprite = emptyHeart;
                break;
            case HeartStatus.Full:
                heartImage.sprite = fullHeart;
                break;
        }
    }
}

public enum HeartStatus {
    Empty = 0,
    Full = 1
}
