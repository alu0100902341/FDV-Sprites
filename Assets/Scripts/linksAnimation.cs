using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linksAnimation : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A)){
            animator.SetBool("walking_left", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("walking_down", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("walking_right", true);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("walking_up", true);
        }
        else
        {
            animator.SetBool("walking_left", false);
            animator.SetBool("walking_down", false);
            animator.SetBool("walking_right", false);
            animator.SetBool("walking_up", false);
        }

    }
}
