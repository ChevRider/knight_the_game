using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor : MonoBehaviour
{
    [SerializeField] private Animator TutorAnim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Attack Tutor"))
            TutorAnim.SetTrigger("Tutor");
    }
}
