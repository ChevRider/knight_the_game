using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    [SerializeField] private bool isAlive;
    public GameObject deadScreen;
    public Transform hero;
    public GameObject knight;
    public Text health_text;
    public Rigidbody2D rb;
    public Animator pers;
    public AudioSource persAudio;
    public AudioSource levelMusic;
    public AudioClip enemyIsDead;
    public AudioClip heroIsDead;
    public AudioClip heroGetHit;
    public AudioSource gameOverMusic;
    public GameObject finishZone;
    public GameObject finishFlag;
    public AudioSource healthSound;
    public Animator healthAnim;
    
    
    


    private void Awake()
    {
        currentHealth = maxHealth;
        isAlive = true;
    }

    public void TakeDamageEnemy(float damage)
    {
        if (isAlive)
        {
            currentHealth -= damage;
            CheckIsAliveEnemy();
            pers.SetTrigger("Hit");
            Score.score += 25;
            persAudio.Play();
        }

    }

    public void TakeDamageHero(float damage)
    {
        if (isAlive)
        {
            currentHealth -= damage;
            CheckIsAliveHero();
            health_text.text = currentHealth.ToString();
            pers.SetTrigger("IsGetHit");
            persAudio.Play();
        }
    }

    private void CheckIsAliveEnemy()
    {
        if (currentHealth > 0)
            isAlive = true;

        if(currentHealth <= 0 && gameObject.name.Contains("Skeleton"))
        {
            isAlive = false;
            pers.SetTrigger("IsDead");
            rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Destroy(gameObject, 1.5f);
            LevelResults.enemyesOnLevelKill++;
            persAudio.clip = enemyIsDead;
            persAudio.Play();
        }

        if (currentHealth <= 0 && gameObject.name.Contains("Flying Eye"))
        {
            isAlive = false;
            pers.SetTrigger("IsDead");
            rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            Destroy(gameObject, 0.5f);
            LevelResults.enemyesOnLevelKill++;
            persAudio.clip = enemyIsDead;
            persAudio.Play();
        }

        if (currentHealth <= 0 && gameObject.name.Contains("Bird"))
        {
            isAlive = false;
            pers.SetTrigger("IsDead");
            rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            Destroy(gameObject, 0.5f);
            LevelResults.enemyesOnLevelKill++;
            persAudio.clip = enemyIsDead;
            persAudio.Play();
        }

        if (currentHealth <= 0 && gameObject.name.Contains("Bandit"))
        {
            isAlive = false;
            pers.SetTrigger("IsDead");
            rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Destroy(gameObject, 1.5f);
            LevelResults.enemyesOnLevelKill++;
            persAudio.clip = enemyIsDead;
            persAudio.Play();
        }

        if (currentHealth <= 0 && gameObject.name.Contains("Boss"))
        {
            isAlive = false;
            pers.SetTrigger("IsDead");
            rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Destroy(gameObject, 1.5f);
            LevelResults.enemyesOnLevelKill++;
            persAudio.clip = enemyIsDead;
            persAudio.Play();
            finishZone.SetActive(true);
            finishFlag.SetActive(true);
        }
    }

    private void CheckIsAliveHero()
    {
        if (currentHealth > 0)
            isAlive = true;

        if (currentHealth <= 0)
        {
            isAlive = false;
            PlayerMovement.isControlled = false;
            currentHealth = 0;
            pers.SetTrigger("IsDead");
            persAudio.clip = heroIsDead;
            persAudio.Play(); 
            levelMusic.Stop();
            deadScreen.SetActive(true);
            gameOverMusic.Play();
            Destroy(gameObject, 2f);
            health_text.text = currentHealth.ToString();
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Dead"))
        {
            gameOverMusic.Play();
            Destroy(gameObject);
            levelMusic.Stop();
            deadScreen.SetActive(true);
            currentHealth = 0;
            health_text.text = currentHealth.ToString();
        }

        if(collision.CompareTag("Health"))
        {
            currentHealth = 100;
            health_text.text = currentHealth.ToString();
            healthSound.Play();
            healthAnim.SetTrigger("Collected");
        }
    }     

    public void EnemyDestroy()
    {
        Destroy(gameObject, 1.5f);
    }
}
