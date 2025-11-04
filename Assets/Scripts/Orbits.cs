using UnityEngine;

public class Orbits : MonoBehaviour
{
    public Transform pivot;

    public float angularSpeed = 20f;

    public float selfRotationSpeed = 30f;

    private void Update()
    {
        if (pivot != null)
        {
            transform.RotateAround(pivot.position, Vector3.up, angularSpeed * Time.deltaTime);
        }
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime, Space.Self);
    }
}
