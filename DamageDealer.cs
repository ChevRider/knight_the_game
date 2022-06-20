using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float damage;
    public Animator skeleton;
    public GameObject damageDealer;
    public Transform damagePoint;
    

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("enemy") && gameObject.CompareTag("Strike"))
        {
            collision.gameObject.GetComponent<Health>().TakeDamageEnemy(damage);
            Debug.Log("Damaged");
            Destroy(gameObject);
        }

        if(collision.CompareTag("Player") && gameObject.CompareTag("enemy"))
        {
            skeleton.SetBool("IsAttack", true);
            
        }

        if(collision.CompareTag("Player") && gameObject.CompareTag("Weapon"))
        {
            collision.gameObject.GetComponent<Health>().TakeDamageHero(damage);
        }
    }

    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && gameObject.CompareTag("enemy"))
        {
            skeleton.SetBool("IsAttack", false);
        }
    }

    public void SkeletonSetDamage() 
    {
       GameObject currentDamageDealer = Instantiate(damageDealer, damagePoint.position, Quaternion.identity);
       Destroy(currentDamageDealer, 0.3f);
    }

    

    


}
