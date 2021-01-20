using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotate : MonoBehaviour
{
    public float turnspeed = 1f;




    private void Update()
    {
        transform.Rotate(Vector3.up, turnspeed *Time.deltaTime/2);
    }
}
