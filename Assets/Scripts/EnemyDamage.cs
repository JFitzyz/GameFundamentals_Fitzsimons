using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damage = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collider)
    {
        collider.collider.GetComponent<Health>()?.Damage(damage);
    }
}
