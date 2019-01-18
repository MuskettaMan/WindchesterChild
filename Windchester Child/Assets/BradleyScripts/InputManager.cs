using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
       
        public bool Up
        {
          get
          {
            if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
            {
                return true;
            }
            else return false;
               
          }
        }

        public bool Down
        {
           get
           {
            if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
            {
                return true;
            }
            else return false;

           }
        }
        public bool Left
        {
          get
          {
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
            {
                return true;
            }
            else return false;
               
          }
        }

        public bool Right
        {
           get
           {
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
            {
                return true;
            }
            else return false;

           }
        }
    
}
