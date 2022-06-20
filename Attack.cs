using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject heroDamageDealer;
    [SerializeField] private Transform heroDamagePoint;
    [SerializeField] private Transform heroTr;

    public void HeroAttack()
    {    
            GameObject currentDealer = Instantiate(heroDamageDealer, heroDamagePoint.position, Quaternion.identity);
            Destroy(currentDealer, 0.3f);            
    }
}
