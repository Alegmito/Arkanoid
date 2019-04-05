using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float speed;
    public string effect;
    public int value;
    public Sprite[] buffTypes;
    public string[] buffNames;
    public int[] buffValues;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, -1f) * Time.deltaTime * speed);

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    public void ChooseBuff()
    {
        int buffTupeNumber = buffTypes.Length;
        int buffNumber = Random.Range(0, buffTupeNumber);
        GetComponent<SpriteRenderer>().sprite = buffTypes[buffNumber];
        effect = buffNames[buffNumber];
        value = buffValues[buffNumber];
    }
}
