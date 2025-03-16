using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class tigerrun : MonoBehaviour
{
    Animator anim;

    // Must be Start(), not start()
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void therun()
    {
        // Must be SetTrigger(), not setTrigger()
        anim.SetTrigger("Run");
    }
}
