using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementWithrotation : MonoBehaviour
{
    float velocity = 15f;
    //float rotationVelocity = 100*Time.deltaTime;

    // Update is called once per frame
    void Update()
    {


        //ensimmäinen lähestymistapa:
        float horizontal = (Input.acceleration.x * 10f);
        float vertical = ((Input.acceleration.y + 0.45f) * 10f);
        Vector3 direction = new Vector3(Mathf.Clamp(horizontal, -1f, 1f), Mathf.Clamp(vertical, -1f, 1f));

        // toinen lähestymistapa:
        //float horizontal = Mathf.Round(Input.acceleration.x * 10f);
        //float vertical = Mathf.Round((Input.acceleration.y + 0.25f) * 10f);
        //Vector3 direction = new Vector3(horizontal, vertical);

        Debug.Log("Vertical acc: " + vertical);
        Debug.Log("Horizontal acc: " + vertical);

        Vector3 destination = new Vector3(horizontal, vertical, 1f);

        transform.position += direction * velocity * Time.deltaTime;
        //toimiva nopeus jos ottaa mathclamp ajon päälle
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(destination), Mathf.Deg2Rad*120f);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(destination), Mathf.Deg2Rad * 100f);

    }

    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15f, 15f), Mathf.Clamp(transform.position.y, -7f, 7f), transform.position.z);
    }
}
