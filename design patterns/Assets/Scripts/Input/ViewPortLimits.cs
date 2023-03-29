using UnityEngine;

namespace Ship
{
    class ViewPortLimits : CheckLimitsInterface
    {
        private float minHorizontalLimit = 0.1f, maxHorizontalLimit = 0.9f;
        private float minVerticalLimit = 0.1f, maxVerticalLimit = 0.9f;
        private Transform _transform;
        private Camera _camera;
    
        public ViewPortLimits(Transform transform, Camera camera)
        {
            _transform = transform;
            _camera = camera;
        }
        public void ClampFinalPosition()
        {
            Vector3 viewportPoint = _camera.WorldToViewportPoint(_transform.position);
            viewportPoint.x = Mathf.Clamp(viewportPoint.x, minHorizontalLimit, maxHorizontalLimit);
            viewportPoint.y = Mathf.Clamp(viewportPoint.y, minVerticalLimit, maxVerticalLimit);
            _transform.position = _camera.ViewportToWorldPoint(viewportPoint);
        }
    }
}

