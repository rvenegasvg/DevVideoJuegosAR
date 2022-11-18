using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickanim : MonoBehaviour
{
    public Animator animator;
    public string nombreAnim;


    public void click()
    {
        animator.SetTrigger(nombreAnim);
    }
}
