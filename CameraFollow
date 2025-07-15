using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float delta = 0.01f;
    public float cameraHight = 0f;
    public float cameraNear = 0f;
    public Transform trans;
    private bool follow = true;
    private void Start() {
        if(!trans)
            trans = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void FixedUpdate()
    {
        if (follow)
            transform.position = new Vector3(0, trans.position.y - (trans.position.y % delta) + cameraHight, cameraNear);
    }
    public void StopFollow()
    {
        follow = false;
    }
}
