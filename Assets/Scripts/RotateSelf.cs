using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    public Vector3 axis = Vector3.up;  
    public float speed = 20f;       

    void Update()
    {
        transform.Rotate(axis, speed * Time.deltaTime, Space.Self);
    }
}
