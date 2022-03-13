using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_movement : MonoBehaviour
{
    private Vector3 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        return new Vector3(x, y, 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = RandomVector(-5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
