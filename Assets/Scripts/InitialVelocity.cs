using UnityEngine;

public class InitialVelocity : MonoBehaviour
{
    public Vector2 velocity = new Vector2(100, 0);
    public Rigidbody2D rb;
    public float speed = 20.0f;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = transform.right * speed;
    }
}