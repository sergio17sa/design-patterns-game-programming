using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ship
{
    public class JoystickAdapter : InputInterface
    {

        private readonly Joystick _joystick;
        public JoystickAdapter(Joystick joystick)
        {
         _joystick = joystick;
        }

        public Vector2 GetDirection()
        {
            return new Vector2(_joystick.Horizontal, _joystick.Vertical);
        }
    }


}
