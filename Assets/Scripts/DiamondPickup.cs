using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DiamondPickup : MonoBehaviour
{
    [SerializeField] int pointsForCoinPickup = 100;
    [SerializeField] AudioClip collectionSoundEffect;
    bool wasCollected = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !wasCollected)
        {

            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);
            AudioSource.PlayClipAtPoint(collectionSoundEffect, Camera.main.transform.position);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

}
