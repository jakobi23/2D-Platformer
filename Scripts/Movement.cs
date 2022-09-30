using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   Rigidbody2D rb;

   bool onGround;
   
   public static int count = 0;

   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(new Vector3 (-0.01f, 0, 0));
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(new Vector3 (0.01f, 0, 0));
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            count = count + 1;    
            Debug.Log(count);    
            if(count <= 2){
                rb.AddForce(new Vector3(0f, 25f), ForceMode2D.Impulse);
            }
            if(onGround == true){
            count = count - count;
            Debug.Log(onGround);
        }

        
        
        }
        
    }

    void HandleCollision()
    {
        Collider2D colls[] = new Collider2D[10]();
        rb.colls.GetContacts();
        for(int i = 0; i <colls.length(); i++)
        {
                if(!colls[i].IsUnityNull())
            {
                if(colls[i].gameObject.tag == "Terrain")
                {
                    onGround = true;
                }
            }
        }
        
    }

}
