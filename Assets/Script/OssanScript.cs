using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OssanScript : MonoBehaviour
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
        //float ax = Input.GetAxisRaw("Horizontal");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        int key = 0;
        if (Input.acceleration.x > threshold) key = 1;
        if (Input.acceleration.x < threshold) key = -1;
        float speedx = Mathf.Abs(rb.velocity.x);
        if(speedx < maxWalkSpeed)
        {
            rb.AddForce(transform.right * key * WalkForce);
        }



        //rb.AddForce(Vector2.right * ax * 3);

        //if (Input.GetKeyDown(KeyCode.Space))
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector2.up * 7, ForceMode2D.Impulse);
        }

        if (transform.position.y < -5)
        {
            transform.position = new Vector3(-7, -2, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Neko")
        {
            SceneManager.LoadScene("08UI");
        }

    }


}
