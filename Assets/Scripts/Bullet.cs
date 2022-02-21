using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public float bulletDamage;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime; //move bullet forward

        //this.transform.rotation = new Quaternion(0, 0, this.transform.rotation.z + 0.1f, 0); //hah!

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")//bullet hit enemy
        {
            //do smth like collision.gameobject.GetComponent<EnemyScript>().health -= bulletDamage;
            Debug.Log("Bullet hit an enemy!!!");
        }

        Destroy(this.gameObject);
    }
}
