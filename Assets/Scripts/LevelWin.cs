using Unity.VisualScripting;
using UnityEngine;

public class LevelWin : MonoBehaviour
{
    public GameObject endOfLevelUI;
    public GameObject endOfLevel;
    public Rigidbody2D rb;
    public GameObject player;
    bool isActive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       if (gameObject.tag == "LevelEnd")
        {
            endOfLevelUI.SetActive(true);
        }
    }
}
