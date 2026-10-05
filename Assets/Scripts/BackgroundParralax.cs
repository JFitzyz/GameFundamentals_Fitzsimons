using UnityEngine;

public class BackgroundParralax : MonoBehaviour
{

    public Transform playerTransform;
    void Update()
    {
        transform.position = playerTransform.position * 0.01f;
    }
}