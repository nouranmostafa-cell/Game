using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float upForce = 250f;
    private bool isDead = false;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upForce));
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
         GetComponent<SpriteRenderer>().color = Color.red;
        GameController.instance.BirdDied();

    }

}
