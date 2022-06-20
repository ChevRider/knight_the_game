using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed, timeToRevert;
    [SerializeField] private SpriteRenderer sr;
    private Rigidbody2D rb;
    public Animator enemy;
    private const float IDLE_STATE = 0;
    private const float WALK_STATE = 1;
    private const float REVERT_STATE = 2;

    private float currentState, currentTimeToRevert;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentState = WALK_STATE;
        currentTimeToRevert = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTimeToRevert >= timeToRevert)
        {
            currentTimeToRevert = 0;
            currentState = REVERT_STATE;
        }

        switch(currentState)
        {
            case IDLE_STATE:
                currentTimeToRevert += Time.deltaTime;
                break;
            case WALK_STATE:
                rb.velocity = Vector2.right * speed;
                break;
            case REVERT_STATE:
                sr.flipX = !sr.flipX;
                speed *= -1;
                currentState = WALK_STATE;
                break;
        }
        enemy.SetFloat("Velocity", rb.velocity.magnitude);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy stopper"))
        {
            currentState = IDLE_STATE;
        }
    }
}
