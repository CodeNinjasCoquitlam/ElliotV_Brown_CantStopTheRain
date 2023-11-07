using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public bool canJump;
    public float jumpPower = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        if (rigidbody.velocity.y < 0.1 && rigidbody.velocity.y > -0.1)
        {
            canJump = true;

        } else
        {
            canJump = false;
        }

        if (Input.GetButtonDown("Jump") && (canJump))
        {
            rigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }

    }
}
