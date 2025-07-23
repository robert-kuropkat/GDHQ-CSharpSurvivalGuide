using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoersOfStuff.UCSSG.ObjectPool
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float mySpeed  = 2;
        [SerializeField] private float lifeSpan = 2;

        private void Update()
        {
            transform.Translate(Vector3.up * (Time.deltaTime * mySpeed));
        }

        private void OnEnable()
        {
            //StartCoroutine(DisableBullet());
            Invoke("DisableBullet", lifeSpan);
        }

        private void DisableBullet()
        {
            //yield return new WaitForSeconds(2);
            this.gameObject.SetActive(false);
        }
    }

}
