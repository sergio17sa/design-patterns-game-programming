using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ship
{
    public class InputAdapter : InputInterface
    {
        public Vector2 GetDirection()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            return new Vector2(horizontal, vertical);
        }
    }
}

