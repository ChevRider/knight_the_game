using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public AudioSource gameMusic;
    public AudioClip bossMusic;
    public GameObject levelBorder;
    public GameObject gameCamera;
    public Rigidbody2D bossRb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            gameMusic.clip = bossMusic;
            gameMusic.Play();
            levelBorder.SetActive(true);
            gameCamera.SetActive(false);
            bossRb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
