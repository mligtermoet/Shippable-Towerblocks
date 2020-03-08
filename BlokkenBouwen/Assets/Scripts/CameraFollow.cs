using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float newY = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //transform.position = new Vector3(0,newY,-8);
        
         Vector3 desiredPosition = new Vector3(0,newY,-8);
         Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, 1f*Time.deltaTime);
         transform.position = smoothedPosition;
    }
}
