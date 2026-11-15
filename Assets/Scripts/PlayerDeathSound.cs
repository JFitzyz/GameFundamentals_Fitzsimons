using JetBrains.Annotations;
using UnityEngine;

public class PlayerDeathSound : MonoBehaviour
{
    public GameObject player;
    public AudioSource deathAudio;
    public Health playerHealth;
    public float soundDelay = 0f;
    public bool hasPlayed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deathAudio = GetComponent<AudioSource>();
        playerHealth = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (soundDelay < 1.0f)
        {
            soundDelay += Time.deltaTime;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject gameObject = collision.gameObject;

        if (playerHealth.health <= 0)
        {
            deathAudio.Play();
            hasPlayed = true;
        }
    }
}
