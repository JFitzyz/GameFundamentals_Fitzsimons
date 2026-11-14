using UnityEngine.UI;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public Image healthBar;
    private Health healthScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthScript = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthScript.updateHealth == true)
        {
            healthBar.fillAmount = healthScript.health / healthScript.maxHealth;
            healthScript.updateHealth = true;
        }
    }
}
