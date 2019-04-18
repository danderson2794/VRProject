using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject explosion;
    public GameObject arrowExplosion;
    public GameObject bulletExplosion;
    public GameObject projectileExplosion;

    void onTriggerEnter(Collider other)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Arrow")
        {
            Instantiate(arrowExplosion, other.transform.position, other.transform.rotation);
        }
        else if (other.tag == "Bullet")
        {
                Instantiate(bulletExplosion, other.transform.position, other.transform.rotation);
                }
        else if (other.tag == "Projectile")
        {
            Instantiate(projectileExplosion, other.transform.position, other.transform.rotation);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
