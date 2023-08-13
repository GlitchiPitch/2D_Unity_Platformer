using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private RidigBody2D
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        ridigBody = GetComponent<RidigBody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        anim.SetTrigger("death");
    }
}
