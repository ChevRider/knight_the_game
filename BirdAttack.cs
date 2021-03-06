using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAttack : MonoBehaviour
{
    public Transform attackPoint;
    [SerializeField] private GameObject poo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            {
            GameObject currentPoo = Instantiate(poo, attackPoint.position, Quaternion.identity);
            Destroy(currentPoo, 1f);
            }

    }
}
