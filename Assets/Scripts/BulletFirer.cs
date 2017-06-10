using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFirer : MonoBehaviour
{
    public GameObject Bullet;
    
    public void Fire(GameObject target)
    {
        GameObject bullet = Instantiate(Bullet, transform);
        bullet.transform.localPosition = Vector3.zero;
        bullet.transform.localScale = Vector3.one;
        bullet.GetComponent<Bullet>().Target = target;
    }
}