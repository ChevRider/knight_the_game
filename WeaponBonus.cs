using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponBonus : MonoBehaviour
{
    public static int weaponCounter;
    [SerializeField] private Text weaponCountText;
    [SerializeField] private Transform bonusBullet;
    [SerializeField] private Transform bonusBulletDestroyPoint;
    [SerializeField] private AudioSource bonusSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            bonusBullet.transform.position = bonusBulletDestroyPoint.transform.position;
            bonusSound.Play();
            weaponCounter += 5;
            weaponCountText.text = weaponCounter.ToString();
            Debug.Log(weaponCounter);
        }
    }

    private void Start()
    {
        weaponCounter = 0;
    }
    private void Update()
    {
        weaponCountText.text = weaponCounter.ToString();
    }
}
