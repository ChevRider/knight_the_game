using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretCoin : MonoBehaviour
{
    private Animator secretCoin;
    private AudioSource secretSound;
    public GameObject secretFound;
    
    void Start()
    {
        secretCoin = GetComponent<Animator>();
        secretSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            secretCoin.SetTrigger("Secret");
            secretFound.SetActive(true);
            secretSound.Play();
            Score.score += 1000;
            Destroy(gameObject, 5f);
        }
    }
}
