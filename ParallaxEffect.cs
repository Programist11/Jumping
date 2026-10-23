using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] Transform cam;
    [SerializeField, Range(0f,1f)] float ParallaxPower;
    [SerializeField] bool disableParallax;
    Vector3 previousPlayerPosition;
    private void Start() {
        if(!cam)
            cam = Camera.main.transform;
        
        previousPlayerPosition = cam.position;
    }
    private void Update() {
        var delta = cam.position - previousPlayerPosition;
        if (disableParallax)
        {
            delta.x = 0;
            delta.z = 0;
        }
        previousPlayerPosition = cam.position;
        transform.position += delta * ParallaxPower;
    }
}
