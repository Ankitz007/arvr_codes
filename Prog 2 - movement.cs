using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rbody;
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float iX = Input.GetAxis("Horizontal");
        float iZ = Input.GetAxis("Vertical");

        float mX = iX * speed;
        float mZ = iZ * speed;

        rbody.AddForce(mX, 0f, mZ);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "wall1")
        {
            rend.material.color = Color.green;
        }
        else if (collision.collider.name == "wall2")
        {
            rend.material.color = Color.yellow;
        }
        else if (collision.collider.name == "wall3")
        {
            rend.material.color = Color.magenta;
        }
        else if (collision.collider.name == "wall4")
        {
            rend.material.color = Color.gray;
        }
    }
}
