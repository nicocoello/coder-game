using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public struct BulletTemplate
{
    public int damage;
    public int ammount;
    public GameObject bulletGO;
}

public class ShootingTDA : MonoBehaviour
{   
    Stack<BulletTemplate> bulletStack = new Stack<BulletTemplate>();

    public Transform firePoint;
    public float bulletForce = 15f;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            Shoot();
            Debug.Log("Disparando");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            QuickSort.SortBulletStack(bulletStack);
            Debug.LogError("ORDENANDO");
        }
    }
    void Shoot()
    {
        if (bulletStack.Count > 0)
        {
            BulletTemplate bulletPrefab = bulletStack.Pop();
            GameObject bullet = null;
            if (bulletPrefab.ammount > 0)
            {
                bullet = Instantiate(bulletPrefab.bulletGO, firePoint.position, firePoint.rotation);
                bulletPrefab.ammount--;
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode.Impulse);
                if (bulletPrefab.ammount > 0)
                {
                    bulletStack.Push(bulletPrefab);
                }
            }         
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        var bltspk = collision.gameObject.GetComponent<BulletPack>();
        if (bltspk)        {
            Debug.Log("Entre");
            AssignNewBullet(bltspk);
            Destroy(collision.gameObject);
        }
    }

    private void AssignNewBullet(BulletPack newPack)
    {
        var bulletArray = bulletStack.ToArray();
        bool found = false;

        for (int i = 0; i < bulletArray.Length; i++)
        {
            if (bulletArray[i].damage == newPack.BulletType.damage)
            {
                bulletArray[i].ammount += newPack.BulletAmount;
                found = true;
                break;
            }
        }

        bulletStack.Clear();
        for (int i = 0; i < bulletArray.Length; i++)
        {
            bulletStack.Push(bulletArray[i]);
        }

        if (!found)
        {
            BulletTemplate temp = new BulletTemplate();            
            temp.ammount = newPack.BulletAmount;
            temp.bulletGO = newPack.BulletType.gameObject;
            bulletStack.Push(temp);
        }

    }
}
