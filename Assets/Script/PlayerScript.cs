using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    float threshold = 0.2f;
    float maxWalkSpeed = 2.0f;
    float WalkForce = 30.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float ax = Input.GetAxisRaw("Horizontal");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        int key = 0;
        if (Input.acceleration.x > threshold) key = 1;
        if (Input.acceleration.x < threshold) key = -1;
        float speedx = Mathf.Abs(rb.velocity.x);
        if (speedx < maxWalkSpeed)
        {
            rb.AddForce(transform.right * key * WalkForce);
        }

        //b.AddForce(Vector2.right * ax * 3);

        if (rb.velocity.y == 0)
        {
            if (Input.GetMouseButtonDown(0))
            //if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
                GetComponents<AudioSource>()[0].Play();
            }
        }

        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("06RigidBody");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hoge")
        {
            Destroy(collision.gameObject);
            GetComponents<AudioSource>()[1].Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "9003")
        {
            SceneManager.LoadScene("09Block");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "12048")
        {
            SceneManager.LoadScene("07Prefab");
        }
    }
}
