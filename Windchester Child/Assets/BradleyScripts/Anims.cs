using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anims : MonoBehaviour
{
    private InputManager InputManager = new InputManager();
    private Animator anim;
    private Vector3 previouspos;
    // Start is called before the first frame update
    void Start()
    {
        previouspos = transform.position;
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

        //walk
        if (InputManager.Up && previouspos == transform.position)
        {
            anim.SetBool("Walking_Back", true);
            anim.SetBool("Walking_Left", false);
            anim.SetBool("Walking_Front", false);
            anim.SetBool("Walking_Right", false);


        }
        else if (InputManager.Left && previouspos == transform.position)
        {
            anim.SetBool("Walking_Left", true);
            anim.SetBool("Walking_Back", false);
            anim.SetBool("Walking_Front", false);
            anim.SetBool("Walking_Right", false);

        }
        else if (InputManager.Down && previouspos == transform.position)
        {
            anim.SetBool("Walking_Front", true);
            anim.SetBool("Walking_Left", false);
            anim.SetBool("Walking_Back", false);
            anim.SetBool("Walking_Right", false);

        }
        else if (InputManager.Right && previouspos == transform.position)
        {
            anim.SetBool("Walking_Right", true);
            anim.SetBool("Walking_Left", false);
            anim.SetBool("Walking_Back", false);
            anim.SetBool("Walking_Front", false);
        }
        else
        {
            anim.SetBool("Walking_Right", false);
            anim.SetBool("Walking_Left", false);
            anim.SetBool("Walking_Back", false);
            anim.SetBool("Walking_Front", false);

        }
        previouspos = transform.position;

    }
}
