using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionAR : MonoBehaviour
{
    string button;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
                if(Physics.Raycast(ray, out hit))
            {
                button = hit.transform.name;
                switch (button)
                {
                    case "Button (1)":
                        animator.SetTrigger("dead");
                        break;
                    case "Button (2)":
                        animator.SetTrigger("alive");
                        break;
                    case "Button (3)":
                        animator.SetTrigger("idle");
                        break;
                }
                    

            }
        }
    }
}
