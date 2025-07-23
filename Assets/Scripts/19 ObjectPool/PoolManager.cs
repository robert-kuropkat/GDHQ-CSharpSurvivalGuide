using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace DoersOfStuff.UCSSG.ObjectPool
{
    public class PoolManager : MonoSingleton<PoolManager>
    {
        [SerializeField] private List<GameObject> bulletPool;
        [SerializeField] private GameObject       bulletPrefab;
        [SerializeField] private GameObject       bulletStorage;
        [SerializeField] private int              startingBulletCount = 10;
        [SerializeField] private int              extendBulletCount   = 5;

        protected override void Init()
        {
            base.Init();
            Debug.Log("Initializing Pool Manager");
            CreateBulletPool(startingBulletCount);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                RequestBullet(new Vector3(Random.Range(-9f,9f),1,1));
        }

        private void CreateBulletPool(int count)
        {
            foreach (var _ in Enumerable.Range(1, count))
            {
                bulletPool.Add(Instantiate(bulletPrefab, bulletStorage.transform));
                bulletPool.Last().SetActive(false);
            }
        }

        public void RequestBullet(Vector3 startPosition)
        {
            if (!bulletPool.Any(i => !i.activeInHierarchy)) { CreateBulletPool(extendBulletCount); }
            GameObject bullet = bulletPool.Where(i => !i.activeInHierarchy).First();
            bullet.transform.position = startPosition;
            bullet.SetActive(true);
        }
    }

}
