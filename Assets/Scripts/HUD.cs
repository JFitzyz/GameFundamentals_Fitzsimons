using UnityEngine.UI;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public Image healthBar;
    public Image enemyHealthBar;
    private Health healthScript;
    private EnemyHealth enemyHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthScript = GetComponent<Health>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthScript.updateHealth == true)
        {
            healthBar.fillAmount = healthScript.health / healthScript.maxHealth;
            healthScript.updateHealth = true;
        }
        //if (enemyHealth.updateEnemyHealth == true)
        //{
        //    enemyHealthBar.fillAmount = enemyHealth.enemyHealth / enemyHealth.enemyHealth;
        //    enemyHealth.updateEnemyHealth = true;
        //}
    }
}
