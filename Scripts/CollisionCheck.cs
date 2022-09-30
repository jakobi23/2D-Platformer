using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    bool onGround;

    void OnCollisionEnter(Collision collision) {
            if(collision.gameObject.tag == "Player"){
                onGround = true;
            }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(onGround);
        if(onGround == true){
            Movement.count = 0;
            Debug.Log(onGround);
        }
        else{
            onGround = false;
        }
    }
}