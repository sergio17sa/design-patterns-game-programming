using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ship
{

    public class Ships : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float minHorizontalLimit = 0.1f, maxHorizontalLimit = 0.9f;
        [SerializeField] private float minVerticalLimit = 0.1f, maxVerticalLimit = 0.9f;
        private Transform _transform;
        private Camera _camera;

        private void Awake()
        {
            _transform = transform;
            _camera = Camera.main;
        }

        private void Update()
        {
            Vector2 direction = GetDirection();
            Move(direction);
        }

        public void Move(Vector2 direction)
        {
            _transform.Translate(direction * (_speed * Time.deltaTime));
            ClampFinalDirection();

        }
        public void ClampFinalDirection()
        {
            Vector3 viewportPoint = _camera.WorldToViewportPoint(_transform.position);
            viewportPoint.x = Mathf.Clamp(viewportPoint.x, minHorizontalLimit, maxHorizontalLimit);
            viewportPoint.y = Mathf.Clamp(viewportPoint.y, minVerticalLimit, maxVerticalLimit);
            _transform.position = _camera.ViewportToWorldPoint(viewportPoint);
        }


        public Vector2 GetDirection()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            return new Vector2(horizontal, vertical);
        }





    }
}
