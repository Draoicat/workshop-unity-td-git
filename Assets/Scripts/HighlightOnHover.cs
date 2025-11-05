using UnityEngine;

public class HighlightOnHover : MonoBehaviour
{

    public Renderer rend;
    public Color couleurDeBase;
    public Color couleurSurvol;
    public TrailRenderer cheminLumineux;

    public float trailTime = 2f;
    public float trailStartWidth = 0.5f; 
    public float trailEndWidth = 0.0f;
    public float trailOpacity = 0.8f;  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
        couleurDeBase = rend.material.color;
        cheminLumineux = GetComponent<TrailRenderer>();
    }

    void OnMouseEnter()
    {
        rend.material.color = couleurSurvol;
        cheminLumineux.enabled = true;

        
        // dégradé
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] {
                new GradientColorKey(couleurSurvol, 0.0f),
                new GradientColorKey(new Color(couleurSurvol.r, couleurSurvol.g, couleurSurvol.b, 0f), 1.0f)
            },
            new GradientAlphaKey[] {
                new GradientAlphaKey(trailOpacity, 0.0f),
                new GradientAlphaKey(0.0f, 1.0f)
            }
        );
        
        cheminLumineux.colorGradient = gradient;
    }
    
    void OnMouseExit()
    {
        rend.material.color = couleurDeBase;
        cheminLumineux.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
