using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float speed = 0.010f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   float h = Input.GetAxisRaw("Horizontal");
   float v = Input.GetAxisRaw("Vertical");
   
   gameObject.transform.position = new Vector2 (transform.position.x + (h * speed), 
      transform.position.y + (v * speed));
    }
}