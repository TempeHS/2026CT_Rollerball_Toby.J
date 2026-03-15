using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Transform orientation;
    public float rotationSpeed = 5f;
    public Vector3 cameraOffset = new Vector3(0, 2, -5);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    // Update is called once per frame
    }
    void LateUpdate()
    {
        transform.position = player.position + orientation.TransformDirection(cameraOffset);
        transform.LookAt(player.position);
    }
}
