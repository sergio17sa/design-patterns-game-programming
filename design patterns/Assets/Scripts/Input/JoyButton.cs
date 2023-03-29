using UnityEngine;
using UnityEngine.EventSystems;

namespace Ship
{
    public class JoyButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
    {
        public bool isPressed { get; private set; }
        public void OnPointerUp(PointerEventData eventData)
        {
            isPressed = false;

        }
        public void OnPointerDown(PointerEventData eventData)
        {
            isPressed = true;
        }

    }

}
