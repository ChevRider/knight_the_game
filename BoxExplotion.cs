using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxExplotion : MonoBehaviour
{
    public GameObject box;
    public GameObject bullet; 
    [SerializeField] private int boxHealth = 3;
    [SerializeField] private Animator boxAnim;
    [SerializeField] private AudioSource boxDamaged;
    [SerializeField] private AudioSource boxDestroyed;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Strike"))
        {
            boxHealth -= 1;
            boxDamaged.Play();
            boxAnim.SetTrigger("IsDamaged");
            Debug.Log("Damaged");
            Destroy(bullet);
        }

        if(boxHealth == 0)
        {
            boxDestroyed.Play();
            boxAnim.SetTrigger("IsDestroyed");
            Destroy(gameObject, 1.5f);
        }
            
        }
    
}
