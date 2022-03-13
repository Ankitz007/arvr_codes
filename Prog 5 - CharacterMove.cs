using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("walk");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetTrigger("run");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            anim.SetTrigger("pose");
        }
    }
}
