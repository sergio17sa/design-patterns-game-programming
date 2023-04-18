using System;
using System.Collections;
using System.Collections.Generic;
using Ships.Weapons;
using UnityEngine;

namespace Ship
{

    public class Ships : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _fireRateInSeconds;
        [SerializeField] private Weapons _projectilePrefab;
        [SerializeField] private Transform _projectileSpawmPosition;

        private Transform _transform;
        private InputInterface _inputInterface;
        private CheckLimitsInterface _checkLimitsInterface;
        private float _remainingSecondsToBeAbleToShoot;

        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            Vector2 direction = GetDirection();
            Move(direction);
            tryShoot();
        }

        private void tryShoot()
        {
            _remainingSecondsToBeAbleToShoot -= Time.deltaTime;
            if (_remainingSecondsToBeAbleToShoot > 0)
            {
                return;
            }

            if (_inputInterface.isFireActionPressed())
            {
                Shoot();
            }

        }

        private void Shoot()
        {
            _remainingSecondsToBeAbleToShoot = _fireRateInSeconds;
            Instantiate(_projectilePrefab, _projectileSpawmPosition.position, _projectileSpawmPosition.rotation);
        }

        public void configure(InputInterface inputInterface, CheckLimitsInterface checkLimitsInterface)
        {
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
