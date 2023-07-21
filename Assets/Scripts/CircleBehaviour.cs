using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBehaviour : MonoBehaviour
{
    [SerializeField] float _speed;
    bool _clockwise;

    private void Start()
    {
        _clockwise = Random.value > 0.5f;
    }

    private void Update()
    {
        if (GameManager.Single.GameActive)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _clockwise = !_clockwise;
            }

            transform.Rotate(0, 0, (_clockwise ? _speed : -_speed) * Time.deltaTime);
        }
    }
}
