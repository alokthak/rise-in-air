using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainEndMarkerDownward : MonoBehaviour
{
    Variables variable;
    float speed;
    // Transform location;
    Vector3 down = new Vector3(0,0,-1);
    void Start(){
        variable = GameObject.Find("Variables").GetComponent<Variables>();
        speed = variable.getSpeed();
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * down);
    }
}
