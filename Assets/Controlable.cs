using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlable : MonoBehaviour
{

    public bool isSelected = false;

    Renderer my_renderer;

    // Start is called before the first frame update
    void Start()
    {
        my_renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    internal void move_up()
    {
        if (isSelected)
        {
            transform.position += Vector3.up;
            my_renderer.material.color = Color.red;
        } 
        
    }
}
