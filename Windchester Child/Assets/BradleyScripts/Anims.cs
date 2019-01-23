using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anims : MonoBehaviour
{
    InputManager InputManager = new InputManager();
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animations();
    }

    public void Animations()
    {
        //idles
        if (InputManager.Up)
        {
            anim.SetBool("Facing_Back", true);
            anim.SetBool("Facing_Left", false);
            anim.SetBool("Facing_Right", false);
            anim.SetBool("Facing_Front", false);
        }
        if (InputManager.Left)
        {
            anim.SetBool("Facing_Left", true);
            anim.SetBool("Facing_Back", false);
            anim.SetBool("Facing_Right", false);
            anim.SetBool("Facing_Front", false);
        }
        if (InputManager.Down)
        {
            anim.SetBool("Facing_Front", true);
            anim.SetBool("Facing_Back", false);
            anim.SetBool("Facing_Left", false);
            anim.SetBool("Facing_Right", false);

        }
        if (InputManager.Right)
        {
            anim.SetBool("Facing_Right", true);
            anim.SetBool("Facing_Back", false);
            anim.SetBool("Facing_Left", false);
            anim.SetBool("Facing_Front", false);
        }

        //moves
    }
}
