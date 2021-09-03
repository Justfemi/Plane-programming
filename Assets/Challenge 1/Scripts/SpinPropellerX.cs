using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float spinSpeed = 800.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(Vector3.right * Time.deltaTime);
        transform.Rotate(0, 0, Time.deltaTime * spinSpeed);
    }
}
