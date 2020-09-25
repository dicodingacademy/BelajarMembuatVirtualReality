using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchpadMovement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(getController());
    }

    Vector3 getController()
    {
        float x = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).x * speed * Time.deltaTime;
        float z = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).y * speed * Time.deltaTime;
        return new Vector3(x, 0, z);
    }
}
