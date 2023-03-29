using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ship
{
    public class Installer : MonoBehaviour
    {
        [SerializeField] private bool AiInput;
        [SerializeField] private bool isJoystick;
        [SerializeField] private Joystick _joystick;
        [SerializeField] private Ships _ship;

        private void Awake()
        {
            _ship.configure(GetInput(), GetLimits());
        }

        
        private InputInterface GetInput()
        {

            if(AiInput){
                return new AiInputAdapter(_ship);
            }

            if (isJoystick)
            {
                return new JoystickAdapter(_joystick);
            }

            Destroy(_joystick.gameObject);
            return new InputAdapter();

        }

        private CheckLimitsInterface GetLimits(){
            return new ViewPortLimits(_ship.transform, Camera.main);
        }
    }
}

