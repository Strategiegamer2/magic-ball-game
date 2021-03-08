using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement2 : MonoBehaviour
{
    public GameObject player;

    public Camera cam;

    public const float Y_Angle_min = -30f;
    public const float Y_Angle_max = 80f;

    public float distance = -5.95f;
    public float distanceY = 2.88f;

    public float sensitivityX = 4f;
    public float sensitivityY = 1f;

    private float currentX = 0f;
    private float currentY = 0f;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        currentX += Input.GetAxis("Mouse X") * sensitivityX;
        currentY += Input.GetAxis("Mouse Y") * sensitivityY;

        currentY = Mathf.Clamp(currentY, Y_Angle_min, Y_Angle_max);
    }

    void LateUpdate()
    {
        Vector3 dir = new Vector3(0, distanceY, -distance);

        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);

        cam.transform.position = player.transform.position + rotation * dir;

        cam.transform.LookAt(player.transform.position);
    }
}
