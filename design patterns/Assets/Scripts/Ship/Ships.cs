using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ship
{

    public class Ships : MonoBehaviour
    {   
        [SerializeField] private float _speed;

        private Transform _transform;

        private InputInterface _inputInterface;
        private CheckLimitsInterface _checkLimitsInterface;

        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            Vector2 direction = GetDirection();
            Move(direction);
        }

        public void configure(InputInterface inputInterface, CheckLimitsInterface checkLimitsInterface){
            _inputInterface = inputInterface;
            _checkLimitsInterface = checkLimitsInterface;
        }

        public void Move(Vector2 direction)
        {
            _transform.Translate(direction * (_speed * Time.deltaTime));
            _checkLimitsInterface.ClampFinalPosition();

        }
        
        public Vector2 GetDirection()
        {
            return _inputInterface.GetDirection();
        }
    }
}
