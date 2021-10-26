using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    [SerializeField] private Animator animator;


    public void TriggerAnim()
    {
        animator.SetBool("hasEntered", true);
    }
    public void FinishAnim()
    {
        animator.SetBool("hasEntered", false);
    }
}
