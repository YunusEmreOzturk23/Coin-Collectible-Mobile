using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rigi;
    bool right;
    bool left;
    float speed=10.0f;
    float jumpSpeed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigi = this.gameObject.GetComponent<Rigidbody>();
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        Vector3 goRight = new Vector3(3.7f, transform.position.y, transform.position.z);
        Vector3 goLeft = new Vector3(-3.6f, transform.position.y, transform.position.z);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.deltaPosition.x > 50.0f)
            {
                right = true;
                left = false;
            }
            if (touch.deltaPosition.x < -50.0f)
            {
                right = false;
                left = true;
                // for right x=3.7 for left x=-3.6
            }
            if (touch.deltaPosition.y > 50.0f)
            {
                anim.SetBool("IsJump", true);
                rigi.velocity = new Vector3(rigi.velocity.x, 0f, rigi.velocity.z);
                rigi.AddForce(Vector3.up * jumpSpeed, ForceMode.VelocityChange);         
            }
           
            else
            {
                anim.SetBool("IsJump", false);
            }
            if (right == true)
            {
                transform.position = Vector3.Lerp(transform.position, goRight, 5 * Time.deltaTime);
            }
            if (left == true)
            {
                transform.position = Vector3.Lerp(transform.position, goLeft, 5 * Time.deltaTime);
            }
        }
    }
}
