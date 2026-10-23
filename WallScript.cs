using UnityEngine;

public class WallScript : MonoBehaviour
{
    private GameObject player;
    private GameObject wallControl;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        wallControl = GameObject.FindGameObjectWithTag("Wall control");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && wallControl.GetComponent<Wallcontrol>().recharge)
        {
            player.GetComponent<PlayerMovement>().moveDirect *= -1;
            wallControl.GetComponent<Wallcontrol>().recharge = false;
        }
        Invoke("Reset", 0.5f);
    }
    private void Reset()
    {
        wallControl.GetComponent<Wallcontrol>().recharge = true;
    }
}
