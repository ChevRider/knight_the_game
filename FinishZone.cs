using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishZone : MonoBehaviour
{
    public GameObject VictoryScreen;
    public AudioSource finishMusic;
    public AudioSource levelMusic;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Finish"))
        {
            VictoryScreenEnable();
        }
    }

    public void VictoryScreenEnable()
    {
        PlayerMovement.isControlled = false;
        VictoryScreen.SetActive(true);
        finishMusic.Play();
        levelMusic.Stop();
    }
}
