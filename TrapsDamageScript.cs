using UnityEngine;

public class TrapsDamageScript : MonoBehaviour
{
    public float deadTime = 0f;
    public float deadPower = 0f;
    public float jumpIndex = 0f;
    private GameObject gameManagement;
    private GameObject player;
    private void Awake()
    {
        gameManagement = GameObject.FindGameObjectWithTag("GameManagement");
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(player.GetComponent<PlayerMovement>().moveDirect * -1 * deadPower, player.GetComponent<Rigidbody2D>().velocity.y * jumpIndex), ForceMode2D.Impulse);
            Invoke("Death", deadTime);
        }
    }
    private void Death()
    {
        gameManagement.GetComponent<Death>().IsDead();
    }
}
