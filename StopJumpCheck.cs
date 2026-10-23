using UnityEngine;

public class StopJumpCheck : MonoBehaviour
{
    // private GameObject rb;
    // private int click;
    // private int score;
    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.gameObject.tag == "Player")
    //     {
    //         Debug.Log("Jump checked");
    //         click = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().amountOfClick;
    //         score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>().score;
    //         rb = GameObject.FindGameObjectWithTag("Player");
    //         Debug.Log("Click " + click + ", Score " + score);
    //         if (click > score + 5)
    //         {
    //             Debug.Log("Additional jump force");
    //             rb.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    //             rb.GetComponent<Rigidbody2D>().AddForce(new Vector2(rb.GetComponent<Rigidbody2D>().velocity.x, 30), ForceMode2D.Impulse);
    //         }
    //         else if (score + 1 == click)
    //         {
    //             Debug.Log("Stop Inertion");
    //             rb.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    //         }
    //     }
    // }
}
