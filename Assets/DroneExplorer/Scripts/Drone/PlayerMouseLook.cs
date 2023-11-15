﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DroneExplorer
{

    /// <summary>
    /// Project: 
    /// This project enables the exploration of 3D space by way of a quad-copter drone. The intent 
    /// is to provide a quick drop in package to allow a user to explore a scene in the Unity Play 
    /// engine. The code is written to be modular and can incorporate other gameplay elements with 
    /// the addition of more scripts.
    /// 
    /// Author: Wilson Sauders 
    /// Email: HamsterUnity@gmail.com
    /// Date:   03 / 14 / 2022 (Happy Pie day)
    /// 
    /// File:
    /// I am the PlayerMouseLook class. I lock the mouse and use its MouseX and MouseY movement axes 
    /// to alter the Common Interface Look value.
    /// </summary>
    public class PlayerMouseLook : MonoBehaviour
    {
        public bool isLocked;               // current state of cursor lock
        public CmnInterface myInterface;    // interface we will alter
        public float mulX;                  // X axis multiplier
        public float mulY;                  // Y axis multiplier

        bool oldIsLocked;                   // remembers past state

        // Start is called before the first frame update
        void Start()
        {
            // ensure isLocked state matches unity state on startup
            if (isLocked)
            {
                LockMouse();
            }
            else
            {
                UnLockMouse();
            }
            oldIsLocked = isLocked;
        }



        // Update is called once per frame
        void Update()
        {
            // check if isLocked was modified externally
            if (isLocked != oldIsLocked)
            {
                if (isLocked)
                {
                    LockMouse();
                }
                else
                {
                    UnLockMouse();
                }
                oldIsLocked = isLocked;
            }

            // don't apply if not locked
            if (isLocked == false) return;
            // reset look
            myInterface.look = Vector2.zero;

            float bufX = Input.GetAxis("Mouse X") * mulX;
            float bufY = Input.GetAxis("Mouse Y") * mulY;

            // pass buffer values into interface
            myInterface.look += Vector3.right * bufX;
            myInterface.look += Vector3.up * bufY;
            return;
        }

        /// <summary>
        /// Lock the mouse and hide the cursor
        /// </summary>
        void LockMouse()
        {
            isLocked = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        /// <summary>
        /// Unlock the mouse and show the cursor
        /// </summary>
        void UnLockMouse()
        {
            isLocked = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}