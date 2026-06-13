using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float force;
    [SerializeField] private GameController gameController;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForceY(force);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ong"))
        {
            Debug.Log("Game Over");
            gameController.GameOver();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AddScore"))
        {
            Debug.Log("Add Score");
            gameController.AddScore();
        }
    }
}