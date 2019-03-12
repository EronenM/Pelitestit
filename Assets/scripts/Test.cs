using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    float velocity = 180f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(Vector3.up * Time.deltaTime * 0.80f);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.acceleration.x * velocity * Time.deltaTime;
        float vertical = Input.acceleration.y * velocity * Time.deltaTime;

        transform.Translate(horizontal, vertical, 0);
    }
    
    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -30f , 30f), Mathf.Clamp(transform.position.y, -15f, 15f), transform.position.z);
    }

}
