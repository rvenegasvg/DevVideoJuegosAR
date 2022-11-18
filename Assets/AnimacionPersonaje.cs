using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPersonaje : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        animator.SetTrigger("dead");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
