using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class VelociraptorController : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Reset all triggers before setting a new one
        ResetAllTriggers();

        if (Input.GetKeyDown(KeyCode.I))
        {
            animator.SetTrigger("IdleTrigger");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("RoarTrigger");
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetTrigger("RunTrigger");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("AttackTrigger");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("DeathTrigger");
        }
    }

    void ResetAllTriggers()
    {
        animator.ResetTrigger("IdleTrigger");
        animator.ResetTrigger("RoarTrigger");
        animator.ResetTrigger("RunTrigger");
        animator.ResetTrigger("AttackTrigger");
        animator.ResetTrigger("DeathTrigger");
    }
}