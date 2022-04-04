using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody hero;
    [SerializeField] private int speed;

    [SerializeField] private Vector2 direction;

    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //hero.MovePosition(hero.position + direction * speed * Time.fixedDeltaTime);
    }
}
