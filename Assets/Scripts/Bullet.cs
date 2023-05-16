using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    public int damage;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnTriggerEnter(Collider other)
    {
        EnemyHealth health = other.gameObject.GetComponent<EnemyHealth>();
        if (health != null)
        {
            health.takeDamage(damage);
        }
    }
}
