using UnityEngine;


public class Shooting : MonoBehaviour
{
    public Vector2 velocity;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().transform.right = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
