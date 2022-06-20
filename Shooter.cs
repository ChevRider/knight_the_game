using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireSpeed;
    [SerializeField] private Transform firePoint;

    [SerializeField] private Transform hero;
    public AudioSource shoot;


   

    public void Shoot(float direction)
    {
        GameObject currentBullet = Instantiate(bullet, firePoint.position, Quaternion.identity);
        shoot.Play();
        
        Destroy(currentBullet, 0.2f);
        Rigidbody2D currentBulletVelocity = currentBullet.GetComponent<Rigidbody2D>();

        if ( hero.localScale.x > 0)
            currentBulletVelocity.velocity = new Vector2(fireSpeed * 1, currentBulletVelocity.velocity.y);
        else
            currentBulletVelocity.velocity = new Vector2(fireSpeed *-1, currentBulletVelocity.velocity.y);

    }

    public void AxeShoot(float direction)
    {
        GameObject currentBullet = Instantiate(bullet, firePoint.position, Quaternion.identity);
        shoot.Play();

        Destroy(currentBullet, 3f);
        Rigidbody2D currentBulletVelocity = currentBullet.GetComponent<Rigidbody2D>();

        if (hero.localScale.x > 0)
            currentBulletVelocity.velocity = new Vector2(fireSpeed * 1, currentBulletVelocity.velocity.y);
        else
            currentBulletVelocity.velocity = new Vector2(fireSpeed * -1, currentBulletVelocity.velocity.y);

    }
}
   
