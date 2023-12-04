using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerenciaZombies : MonoBehaviour
{
    public int life = 5;
    public int damage = 1;
    public float speedX = 1;
    public float directionX = -1;
    private Rigidbody2D _compRigidbody;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speedX * directionX, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Destructor"))
        {
            Destroy(this.gameObject);
        }
    }
}
