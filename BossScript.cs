using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 30;
    public float leftScreenEdge;
    public float rightScreenEdge;
    public GameManager gm;
    public Transform powerUp;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right  * Time.deltaTime * speed);
        if (transform.position.x < leftScreenEdge)
        {
            transform.position = new Vector2(leftScreenEdge, transform.position.y);
        }
        if (transform.position.x > rightScreenEdge)
        {
            transform.position = new Vector2(rightScreenEdge, transform.position.y);
        }
    }

    public void UseAttack()
    {
        powerUp.GetComponent<PowerUpScript>().effect="Extra life";
        powerUp.GetComponent<PowerUpScript>().value=-1;
        Instantiate(powerUp, transform.position, transform.rotation);
    }

    public void StartMoving()
    {
        rb.AddForce(Vector2.right * speed);
    }
}
