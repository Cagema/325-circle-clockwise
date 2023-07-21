using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bonus"))
        {
            GameManager.Single.Score++;
            Destroy(collision.gameObject);
            return;
        }
        else
        {
            GameManager.Single.Lives--;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
