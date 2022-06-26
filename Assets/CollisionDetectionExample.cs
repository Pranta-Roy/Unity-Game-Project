using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision c)
    {
        print("collided with "+c.gameObject.name);
    }

    // // Update is called once per frame
    // void OnCollisionExit()
    // {
    //     //print("is exiting");
    // }

    // void OnCollisionStay()
    // {
    //    //print("is staying");
    // }

    void OnTriggerEnter(Collider c)
    {
      print("Triggered with "+c.gameObject.name);
    }

    // void OnTriggerExit()
    // {
    //   print("exiting Trigger");
    // }

    // void OnTriggerStay()
    // {
    //     print("staying in Trigger");

    // }
}
