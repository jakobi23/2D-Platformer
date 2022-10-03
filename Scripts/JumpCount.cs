using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JumpCount : MonoBehaviour
{

    Text txt;
    static int jumpCount;
    // Start is called before the first frame update
    void Start()
    {
        jumpCount = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (jumpCount > 0)
            {
                jumpCount = jumpCount - 1;
                txt.text = "" + jumpCount.ToString();
            }
        }
    }
}
