using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ships.Weapons
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Weapons : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody2D _rigidbody2D;


        private void Start()
        {
            _rigidbody2D.velocity = transform.up * speed;
            StartCoroutine(DestroyIn(3));
            
        }


        public IEnumerator DestroyIn(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            Destroy(gameObject);
        }
    }

}

