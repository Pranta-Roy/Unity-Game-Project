using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cameraComponent;
    public float zoomSize = 0.01f;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        CameraSize();
    }
    void CameraSize(){
        if(Input.GetKey(KeyCode.E) && (cameraComponent.orthographicSize<10))
        {
            
          cameraComponent.orthographicSize += zoomSize;
        }
        if(Input.GetKey(KeyCode.Q)&& (cameraComponent.orthographicSize>1))
        {
            
          cameraComponent.orthographicSize -= zoomSize;
        }

    }
}
