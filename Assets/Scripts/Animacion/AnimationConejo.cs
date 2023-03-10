using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationConejo : MonoBehaviour
{
    public Animator anim;
    public KeyCode teclas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (Input.GetKeyDown(teclas))
        {
            anim.SetTrigger("conejo");
        }

    }
}
