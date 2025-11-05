using UnityEngine;

public class QuitApp : MonoBehaviour
{
    void Update()
    {
        // si on appuie sur Échap
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            print("Escape");

        }
    }
}
