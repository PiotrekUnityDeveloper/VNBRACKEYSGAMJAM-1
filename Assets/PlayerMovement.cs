using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float HMVdistance; //horizontal speed
    public float VMVdistance; //verical speed

    public float jumpHeight;

    public int movementVariationScale;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private int speedRValue;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            int i = ((int)HMVdistance * 1);

            i += speedRValue;

            if(this.gameObject.GetComponent<Rigidbody2D>().velocity.x < 0.5f && this.gameObject.GetComponent<Rigidbody2D>().velocity.x > -0.5f)
            {
                this.GetComponent<Rigidbody2D>().velocity = 1.1f /* dwd2a*/ * new Vector2(this.GetComponent<Rigidbody2D>().velocity.x + HMVdistance * i, this.GetComponent<Rigidbody2D>().velocity.y * i)/* * Time.deltaTime*/;
            }

            
        }

        if (Input.GetKey(KeyCode.A))
        {
            int i = ((int)HMVdistance * 1);

            i += speedRValue;

            if (this.gameObject.GetComponent<Rigidbody2D>().velocity.x < 0.5f && this.gameObject.GetComponent<Rigidbody2D>().velocity.x > -0.5f)
            {
                this.GetComponent<Rigidbody2D>().velocity = 1.1f /* dwd2a*/ * new Vector2(this.GetComponent<Rigidbody2D>().velocity.x - HMVdistance * i, this.GetComponent<Rigidbody2D>().velocity.y * i)/* * Time.deltaTime*/;
            }


        }

        if (Input.GetKey(KeyCode.W))
        {
            int i = ((int)HMVdistance * 1);

            i += speedRValue;

            if (this.gameObject.GetComponent<Rigidbody2D>().velocity.x < 0.5f && this.gameObject.GetComponent<Rigidbody2D>().velocity.x > -0.5f)
            {
                this.GetComponent<Rigidbody2D>().velocity = 1.1f /* dwd2a*/ * new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, this.GetComponent<Rigidbody2D>().velocity.y + HMVdistance * i)/* * Time.deltaTime*/;
            }


        }

        if (Input.GetKey(KeyCode.S))
        {
            int i = ((int)HMVdistance * 1);

            i += speedRValue;

            if (this.gameObject.GetComponent<Rigidbody2D>().velocity.x < 0.5f && this.gameObject.GetComponent<Rigidbody2D>().velocity.x > -0.5f)
            {
                this.GetComponent<Rigidbody2D>().velocity = 1.1f /* dwd2a*/ * new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, this.GetComponent<Rigidbody2D>().velocity.y - HMVdistance * i)/* * Time.deltaTime*/;
            }


        }
    }

    private int timeElapsed;

    private void FixedUpdate()
    {
        while(timeElapsed < 100f) //dur
        {
            speedRValue = (int)Mathf.Lerp(HMVdistance - movementVariationScale, HMVdistance + movementVariationScale, timeElapsed / 2f);
            timeElapsed += 1;
        }

        timeElapsed = 0;

        while (timeElapsed < 100f) //dur
        {
            speedRValue = (int)Mathf.Lerp(HMVdistance - movementVariationScale, HMVdistance + movementVariationScale, timeElapsed / 2f);
            timeElapsed -= 1;

            //max value is 100 i believe
            //SORRY FOR COMPLICATED CODE :3 IT WORKS! THATS WHAT MATTERS RIGHT?
        }
    }
}
