using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinningcube : MonoBehaviour
{
    public float speed = 50f;
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
