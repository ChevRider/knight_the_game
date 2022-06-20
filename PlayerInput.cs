using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(Shooter))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Shooter shooter;
    [SerializeField] private bool facingRight = true;
    [SerializeField] private Animator heroAnim;
    [SerializeField] private AudioSource heroAttack;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        shooter = GetComponent<Shooter>();
    }

    private void Update()
    {
        float horizontalDirection = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
        bool isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.JUMP);

        if (Input.GetButtonDown(GlobalStringVars.FIRE_1) && PlayerMovement.isControlled && WeaponBonus.weaponCounter > 0)
        {
            shooter.Shoot(horizontalDirection);
            WeaponBonus.weaponCounter -= 1;
            Debug.Log(WeaponBonus.weaponCounter);
        }

        if (Input.GetButtonDown(GlobalStringVars.FIRE_2) && PlayerMovement.isControlled)
        {
            heroAnim.SetBool("HeroIsAttack", true);
        }
            

        playerMovement.Move(horizontalDirection, isJumpButtonPressed);

        if(horizontalDirection > 0 && !facingRight && PlayerMovement.isControlled)
        {
            Flip();
        }
        else if(horizontalDirection < 0 && facingRight && PlayerMovement.isControlled)
        {
            Flip();
        }
    }
    
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void HeroAttackSound()
    {
        heroAttack.Play();
    }
}
