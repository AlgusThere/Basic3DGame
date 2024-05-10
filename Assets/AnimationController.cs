using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;

    public float speed;
    public float kos;
    public float ziplamaHizi;
    float x, z;
    Vector3 hareket = Vector3.zero;
    Vector3 kosu = Vector3.zero;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(0, 0, 1 * speed * Time.deltaTime);
            //x = Input.GetAxis("Horizontal");
            //z = Input.GetAxis("Vertical");
            //hareket = new Vector3(x, 0.0f, z) * Time.deltaTime * speed;
            ////animator.MovePosition(transform.position + transform.TransformDirection(hareket));
            //transform.position += hareket;
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(0, 0, 1 * -speed * Time.deltaTime);
            //x = Input.GetAxis("Horizontal");
            //z = Input.GetAxis("Vertical");
            //hareket = new Vector3(x, 0.0f, z) * Time.deltaTime * speed;
            ////animator.MovePosition(transform.position + transform.TransformDirection(hareket));
            //transform.position += hareket;
        }
        else
        {
            //animator.SetBool("isWalking", false);
        }
        if(Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(1 * -speed * Time.deltaTime, 0, 0));
            transform.Rotate(0,-1,0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(1 * speed * Time.deltaTime, 0, 0));
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJump", true);
            rb.AddForce(new Vector3(0, ziplamaHizi, 0), ForceMode.Impulse);
        }
        else
        {
            animator.SetBool("isJump", false);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("isRun", true);
            transform.Translate(0, 0, 1 * kos * Time.deltaTime);
            //x = Input.GetAxis("Horizontal");
            //z = Input.GetAxis("Vertical");
            //kosu = new Vector3(x, 0.0f, z) * Time.deltaTime * kos;
            ////rb.MovePosition(transform.position + transform.TransformDirection(hareket));
            //transform.position += kosu;
        }
        else
        {
            animator.SetBool("isRun", false);
        }
    }
}
