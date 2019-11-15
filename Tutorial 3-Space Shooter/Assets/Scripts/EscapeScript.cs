using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}