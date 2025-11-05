using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnAsteroid : MonoBehaviour
{

    public Transform target;
    public GameObject asteroidPrefab;
    public float distance = 70f;
    public float rotationSpeed = 8f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(0))
            {
            
                Vector3 p = target.position + Random.onUnitSphere * distance;
                GameObject asteroid = Instantiate(asteroidPrefab, p, Quaternion.identity);
                
                OrbitAsteroide orbit = asteroid.GetComponent<OrbitAsteroide>();
                    if (orbit != null)
                    {
                        orbit.target = target;
                        orbit.orbitSpeed = Random.Range(10f, 60f);
                    }
            }


    }
}