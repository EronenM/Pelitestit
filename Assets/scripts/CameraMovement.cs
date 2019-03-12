using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject Cylinder;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Cylinder.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Cylinder.transform.position + offset;
    }
}
