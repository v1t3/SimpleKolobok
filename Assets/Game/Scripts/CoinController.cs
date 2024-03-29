﻿using UnityEngine;

namespace Game.Scripts
{
    public class CoinController : MonoBehaviour
    {
        private CoinManager _coinManagerScript;

        private Animation _animation;

        private void Awake()
        {
            _coinManagerScript = FindObjectOfType<CoinManager>();
            _animation = GetComponent<Animation>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _coinManagerScript.PlayCoinPickupSound();
                _coinManagerScript.UpdateCoinsCount(this);

                Destroy(gameObject);
            }
        }

        public void StartAnimation()
        {
            _animation.Play();
        }
    }
}