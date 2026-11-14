using UnityEngine;
public class EnemyHealth : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private PlayerBullet playerBullet;
    public float enemyHealth = 100f;
    public float maxEnemyHealth = 100f;

    public GameObject enemy;
    private bool isEnemyDead;
    bool isEnemyHit = false;
    float time = 0.4f;
    public bool updateEnemyHealth = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerBullet = GetComponent<PlayerBullet>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnemyHit == true)
        {
            time -= Time.deltaTime;
        }
        if (time < 0)
        {
            isEnemyHit = false;
        }
    }

    public void EnemyDamage(float playerDamage)
    {
        enemyHealth -= playerBullet.playerDamage;
        updateEnemyHealth = true;

        if (enemyHealth <= 0 && isEnemyDead == false)
        {
            isEnemyDead = true;
            Destroy(enemy);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "PlayerBullet")
        {
            isEnemyHit = true;
        }
    }
}
