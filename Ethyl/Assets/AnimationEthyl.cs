using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEthyl : MonoBehaviour
{
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.SetTrigger("Idle");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetTrigger("Walk");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetTrigger("Dance");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
