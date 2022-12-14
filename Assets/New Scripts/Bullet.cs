using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public bool isMelee;
    public bool isStar;

    void OnCollisionEnter(Collision collision)
    {
        if(!isStar && collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject, 3);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isMelee && other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        else if (!isMelee && !isStar && other.gameObject.tag =="Floor")
        {
            Destroy(gameObject);
        }
    }
}
