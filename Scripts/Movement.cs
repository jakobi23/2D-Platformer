using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   Rigidbody2D rb;

   bool onGround;
   
   public static int count = 0;

    Collider2D coll;

   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(new Vector3 (-0.05f, 0, 0));
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(new Vector3 (0.05f, 0, 0));
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            count = count + 1;    
            Debug.Log(count);    
            if(count <= 500){
                rb.AddForce(new Vector3(0f, 25f), ForceMode2D.Impulse);
            }
            
        }
        
        
        
        }
        

}
