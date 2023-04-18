using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ship
{
    public class JoystickAdapter : InputInterface
    {

        private readonly JoyButton _joyButton;
        private readonly Joystick _joystick;
        public JoystickAdapter(Joystick joystick, JoyButton joyButton)
        {
         _joystick = joystick;
         _joyButton = joyButton;
        }

        public Vector2 GetDirection()
        {
            return new Vector2(_joystick.Horizontal, _joystick.Vertical);
        }

        public bool isFireActionPressed()
        {
            return _joyButton.isPressed;
        }
    }


}
