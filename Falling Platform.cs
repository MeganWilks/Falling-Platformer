using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    private float PlatformFallDelay = 0.5f; // Seconds before platform falls
    private float PlaformDestroyDelay = 2f; // Seconds before platform is destroyed

    [SerializeField] private Rigidbody2D rb;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
        
    }
    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(PlatformFallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic; // Changes the Rigidbody tyoe to either Dynamic/Static/Kinematic
        Destroy(gameObject, PlaformDestroyDelay);
    }

}
