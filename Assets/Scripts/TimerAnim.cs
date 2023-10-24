using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerAnim : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
