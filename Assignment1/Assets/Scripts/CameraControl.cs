using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start(){
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    /*The LateUpdate() is to guarantee that all the 
    update has been done in each frame and then update 
    this function.*/
    void LateUpdate(){
        transform.position = player.transform.position + offset;
    }
}
