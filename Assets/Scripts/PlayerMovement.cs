using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float VMVdistance = 2222;
    public float HMVdistance = 2222; //these variables are meant to be MOVEMENT SPEED

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //this.gameObject.GetComponent<Rigidbody>().velocity = new Vector2(this.transform.position.x + HMVdistance, this.transform.position.y);
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, VMVdistance * 1), ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //this.gameObject.GetComponent<Rigidbody>().velocity = new Vector2(this.transform.position.x + HMVdistance, this.transform.position.y);
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, VMVdistance * -1f), ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //this.gameObject.GetComponent<Rigidbody>().velocity = new Vector2(this.transform.position.x + HMVdistance, this.transform.position.y);
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(HMVdistance * -1f, 0), ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //this.gameObject.GetComponent<Rigidbody>().velocity = new Vector2(this.transform.position.x + HMVdistance, this.transform.position.y);
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(HMVdistance * 1f, 0), ForceMode2D.Force);
        }
    }

    public void Shoot()
    {
        //shooting will be here soon :)
    }
}
