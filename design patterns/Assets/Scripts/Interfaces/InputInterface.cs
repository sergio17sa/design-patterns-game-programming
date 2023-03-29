using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ship
{
    public interface InputInterface
    {
        Vector2 GetDirection();
        bool isFireActionPressed();
    }

}
