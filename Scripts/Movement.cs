using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   Rigidbody2D rb;
   float yPos;
   int count = 0;
   float force = - 0.1f;
   float rightForce = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        yPos = transform.position.y;
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(new Vector2(force, 0f), ForceMode2D.Impulse);
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(new Vector2(rightForce, 0f), ForceMode2D.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.Space) && count>2){
            Debug.Log(count);
            count = count + 1;    
            rb.AddForce(new Vector2(0f, 0.5f), ForceMode2D.Impulse);
        }
        if(yPos == -3.4){
            count = 0;
        }
    }

}
