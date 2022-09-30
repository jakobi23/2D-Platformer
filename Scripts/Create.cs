using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{

    public GameObject littleDude;
    Vector2 starting = new Vector2((float)-40.25, (float) -3.4);
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(littleDude, new Vector3((float)-40.25, (float)-3.4), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
