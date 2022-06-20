using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public AudioSource coinAudio;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinsText.coins++;
            Score.score += 10;
            CoinsText.coinsText.text = CoinsText.coins.ToString();
            coinAudio.Play();
            Destroy(gameObject);
        }
    }
}
