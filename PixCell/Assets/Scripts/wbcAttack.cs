using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wbcAttack : MonoBehaviour
{

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Not reading this input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("Swing");
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("Punch");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            Destroy(enemy.gameObject);
            Debug.Log("Attack" + hitEnemies);
        }

    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
