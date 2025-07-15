using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private GameObject player;
    private GameObject cam;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            cam.GetComponent<CameraFollow>().StopFollow();
            Invoke("IsDead", 0.3f);
        }
    }
    public void IsDead()
    {
        Destroy(player);
        SceneManager.LoadScene("SessionScene");
    }
}
