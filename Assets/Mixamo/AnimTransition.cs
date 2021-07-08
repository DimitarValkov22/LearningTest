using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTransition : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("IsWalking");
        isRunningHash = Animator.StringToHash("IsRunning");
    }

    
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPress = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);
        bool isrunning = animator.GetBool(isRunningHash);

        if (!isWalking && forwardPress)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !forwardPress)
        {
            animator.SetBool(isWalkingHash, false);
        }


        if(!isrunning && (forwardPress && runPressed))
        {
            animator.SetBool(isRunningHash, true);
        }

        if(isrunning && (!forwardPress || !runPressed))
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
