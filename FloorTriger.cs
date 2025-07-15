using UnityEngine;

public class FloorTriger : MonoBehaviour
{
    private Collider2D coll;
    private GameObject score;
    private Transform player;
    private void Awake()
    {
        coll = GetComponent<Collider2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        score = GameObject.FindGameObjectWithTag("Score");
    }
    // private void OnTriggerEnter2D(Collider2D other) {
    //     if (other.gameObject.tag == "Player") {
    //         other.gameObject.GetComponent<PlayerMovement>().isGrounded = true;
    //     }
    // }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (player.position.y - 0.6f > transform.position.y + 0.16f)
            {
                coll.isTrigger = false;
                score.GetComponent<Score>().AddScore();
                Debug.Log("Score++");
            }
        }
    }
}
