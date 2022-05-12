using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <summary>
// Attaches radial gizmo to object. When spacebar is hit, object overlapping 
// gizmo destroyed.
// </summary>
public class WbcAttack : MonoBehaviour
{
    // TODO:
    // - Write summaries for public classes
    public Transform AttackPoint;
    public float AttackRange = 0.5f;
    public LayerMask EnemyLayers;
    public Animator Animator;
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
        Animator.SetTrigger("Punch");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, EnemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            Destroy(enemy.gameObject);
            Debug.Log("Attack" + hitEnemies);
        }

    }

    void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
        return;

        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }

}
