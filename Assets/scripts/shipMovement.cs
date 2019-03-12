using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{
    float velocity = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
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
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15f, 15f), Mathf.Clamp(transform.position.y, -7f, 7f), transform.position.z);
    }
}
