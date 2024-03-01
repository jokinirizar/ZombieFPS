using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerScript playerScript;
    private float damage = 20;
    void Start()
    {
        
    }

    public void onAttack()
    {
        playerScript.DealDamage(damage);
    }

}
