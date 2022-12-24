using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;
    
    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", Mathf.Lerp(movement.x,1,0.3f));
        animator.SetFloat("Vertical", Mathf.Lerp(movement.y,1,0.3f));
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }



}
