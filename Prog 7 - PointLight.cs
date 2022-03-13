using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLight : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Color col = new Color();
            col.r = 1f;
            col.g = 1f;
            col.a = 1f;
            light.color = col;
        }
        if(Input.GetMouseButtonDown(0))
        {
            Color col = new Color();
            col.r = 1f;
            col.a = 1f;
            light.color = col;
        }
    }
}
