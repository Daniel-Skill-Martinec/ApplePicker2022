using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get current screen position of the mouse from Input
        Vector3 mousePos2d = Input.mousePosition;
        // The camera's z position sets how far to push the mouse into 3d
        //If this line causes a NullReferenceExcepion, select Main Camera in the heriarchy and set its tag to MainCamera
        mousePos2d.z = -Camera.main.transform.position.z;
        //Convert the point from 2d space to 3d world
        Vector3 mousePos3d = Camera.main.ScreenToWorldPoint(mousePos2d);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3d.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Find out what this basket
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.CompareTag("Apple") )
        {
            Destroy(collidedWith);
        }
    }
}
