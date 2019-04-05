using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float speed=10;
    public float leftScreenEdge;
    public float rightScreenEdge;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right*horizontal*Time.deltaTime*speed);
        if (transform.position.x < leftScreenEdge)
        {
            transform.position = new Vector2(leftScreenEdge, transform.position.y);
        }
        if (transform.position.x > rightScreenEdge)
        {
            transform.position = new Vector2(rightScreenEdge, transform.position.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.UsePowerUp(collision.gameObject.GetComponent<PowerUpScript>().effect, collision.gameObject.GetComponent<PowerUpScript>().value);
        Destroy(collision.gameObject);
    }
}
