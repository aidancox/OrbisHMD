using UnityEngine;
using System.Collections;

public class CamMovement : MonoBehaviour
{
    public float sensitivity;
    public bool lockZ;
    void Update()
    {
        //Input
        transform.RotateAround(Vector3.zero, -transform.up, sensitivity * Input.GetAxis("Horizontal"));
        transform.RotateAround(Vector3.zero, transform.right, sensitivity * Input.GetAxis("Vertical"));
        //Touch
        if (Input.touchCount > 0)
        {
            transform.RotateAround(Vector3.zero, -transform.up, sensitivity * -Input.touches[0].deltaPosition.x / 10);
            transform.RotateAround(Vector3.zero, transform.right, sensitivity * -Input.touches[0].deltaPosition.y / 10);
        }
        //Ray
        if (Physics.Raycast(transform.TransformPoint(0,0,0.25f), transform.forward, 0.25f))
        {
            Application.LoadLevel("Main");
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Main");
        }

        if(lockZ)
        {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
    }
}
