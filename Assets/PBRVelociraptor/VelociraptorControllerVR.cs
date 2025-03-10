using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

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

        // A Button (Drink)
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            animator.SetTrigger("DrinkTrigger");
        }

        // B Button (Roar)
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            animator.SetTrigger("RoarTrigger");
        }

        // Thumbstick Press (Run)
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            animator.SetTrigger("RunTrigger");
        }

        // Hand Trigger / Grip Button (Attack)
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0.5f)
        {
            animator.SetTrigger("AttackTrigger");
        }

        // Index Trigger (Death)
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.5f)
        {
            animator.SetTrigger("DeathTrigger");
        }
    }

    void ResetAllTriggers()
    {
        animator.ResetTrigger("DrinkTrigger");
        animator.ResetTrigger("RoarTrigger");
        animator.ResetTrigger("RunTrigger");
        animator.ResetTrigger("AttackTrigger");
        animator.ResetTrigger("DeathTrigger");
    }
}
