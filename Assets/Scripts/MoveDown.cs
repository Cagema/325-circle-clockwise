using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.Single.GameActive)
        {
            transform.Translate(GameManager.Single.Speed * Time.deltaTime * Vector3.down);
        }
    }

    private void FixedUpdate()
    {
        if (transform.position.y < -GameManager.Single.RightUpperCorner.y)
        {
            Destroy(gameObject);
        }
    }
}
