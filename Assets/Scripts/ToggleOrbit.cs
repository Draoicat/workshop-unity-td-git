using UnityEngine;

public class ToggleOrbit : MonoBehaviour
{
    private Orbits orbit;
    public KeyCode toggleKey = KeyCode.Space; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orbit = GetComponent<Orbits>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))

        {
            orbit.enabled = !orbit.enabled;
         }

    }
}
