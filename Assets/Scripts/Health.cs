using UnityEngine;

public interface IDamageable
{
    void Damage(float amount);
}
public class Health : MonoBehaviour, IDamageable
{

    private SpriteRenderer spriteRenderer;
    public float health = 100f;
    public float maxHealth = 100f;

    public GameOverScreen gameManager;
    public PlayerDeathSound playerDeathSound;
    public GameObject player;
    public bool isDead;
    bool isHit = false;
    float time = 0.4f;
    public bool updateHealth = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerDeathSound = GetComponent<PlayerDeathSound>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit == true)
        {
            time -= Time.deltaTime;
        }
        if (time < 0)
        {
            isHit = false;
        }
    }

    public void Damage(float damage)
    {
        health -= damage;
        updateHealth = true;

        if (health <= 0 && isDead == false)
        {
            isDead = true;
            Time.timeScale = 0f;
            gameManager.gameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "Enemy")
        {
            isHit = true;
        }
    }
}
