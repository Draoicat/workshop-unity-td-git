using UnityEngine;

public class OrbitAsteroide : MonoBehaviour
{
    public Transform target; 
    public float orbitSpeed = 20f;

    void Update()
    {
        transform.RotateAround(target.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
