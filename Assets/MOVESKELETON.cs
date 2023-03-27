using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVESKELETON : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            anim.SetTrigger("WALK");
        if (Input.GetKeyDown(KeyCode.R))
            anim.SetTrigger("RUN");
        if (Input.GetKeyDown(KeyCode.D))
            anim.SetTrigger("DEAD");

    }
}
