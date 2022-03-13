using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
    }
}
