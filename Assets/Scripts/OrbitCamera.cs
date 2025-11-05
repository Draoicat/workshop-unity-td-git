using UnityEngine;

public class OrbitCamera : MonoBehaviour
{

    public Transform target;
    public float rotationSpeed = 300f;
    public float minDistance = 30f;
    public float maxDistance = 600f;
    private float currentDistance;
    public float distance = 100f;
    public float zoomSpeed = 70f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentDistance = distance;
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(target);

        float rotationX = Input.GetAxis("Horizontal");
        transform.RotateAround(target.position, Vector3.up, rotationX * rotationSpeed * Time.deltaTime);

        float zoom = Input.GetAxis("Vertical");
        distance -= zoom * zoomSpeed * Time.deltaTime;
        transform.position = target.position - transform.forward * distance;

    }
}
