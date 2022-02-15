using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPack : MonoBehaviour
{
    [SerializeField] private Bullet bulletType;
    [SerializeField] private int bulletAmount = 0;
    //getter
    public int BulletAmount => bulletAmount;

    public Bullet BulletType => bulletType;
}
