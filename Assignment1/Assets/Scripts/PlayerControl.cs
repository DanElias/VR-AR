using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameObject explosion;


    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("PickUp")){
            GameObject explosionClone = Instantiate(explosion, other.gameObject.transform.position, other.gameObject.transform.rotation);
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
