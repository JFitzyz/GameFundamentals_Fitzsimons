using UnityEngine;

public class InitialVelocity : MonoBehaviour
{
    public Vector2 velocity = new Vector2(100, 0);
    public Rigidbody2D rb;
    public GameObject playerBullet;
    public GameObject enemyBullet;
    public float speed = 20.0f;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = transform.right * speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(playerBullet);
        Destroy(enemyBullet);
    }
}