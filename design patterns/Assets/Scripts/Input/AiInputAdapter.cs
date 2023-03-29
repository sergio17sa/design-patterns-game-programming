using UnityEngine;

namespace Ship
{
    internal class AiInputAdapter : InputInterface
    {
        readonly Ships _ship;
        int _directionX;
        Camera _camera = Camera.main;


        public AiInputAdapter(Ships ship)
        {
            _ship = ship;
            _directionX = 1;
        }

        public Vector2 GetDirection()
        {
            Vector3 viewportPoint = _camera.WorldToViewportPoint(_ship.transform.position);
      
            if (viewportPoint.x < 0.1f)
            {
                _directionX = 1;
               
            }
            else if (viewportPoint.x > 0.89f)
            {
                _directionX = -1;
                
            }

            return new Vector2(_directionX, 0);
        }

        public bool isFireActionPressed()
        {
            return Random.Range(1,100) < 20;
        }
    }
}