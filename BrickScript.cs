using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BrickScript : MonoBehaviour
{

    public Animator animator;
    public int points;
    public GameObject ball;
    public Sprite[] hitSprites;
    public int hitsToBreak;

    private int time = 0;
    private IEnumerator coroutine;

    IEnumerator WaitAndPrint()
    {
        while (true)
        {
            if (time<=11)
            {
                time++;
                yield return new WaitForSeconds(1);
            }
            else
            {
                time = 1;
                yield return new WaitForSeconds(1);
            }
            yield return null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       coroutine = WaitAndPrint();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ChangeSprite()
    {
        hitsToBreak--;
        GetComponent<SpriteRenderer>().sprite = hitSprites[hitSprites.Length - hitsToBreak-1];
    }


    public void RandomBuff()
    {
        StartCoroutine(coroutine);
        if (time % 10 != 0)
        {
            int a = Random.Range(1, 15);
            switch (a)
            {
                case 1: // ускорение

                    break;

                case 2: // замедление 
                    break;
                case 3: // огненный персонаж
                    break;
                case 4: // клонирование 
                    break;
                case 5: // множитель бонуса
                    break;
                case 6: // уменьшение радиуса персонажа
                    break;
                case 7: // увеличение радиса персонажа
                    break;
                case 8: // переворот экрана
                    break;
                case 9: // прозрачный шар
                    break;
                case 10: // падающая бомба
                    break;
                case 11: // уменьшение платфоры
                    break;
                case 12: // увеличение платформы 
                    break;
                case 13: // скользкая платформа
                    break;
                case 14: // черный экран
                    break;
            }
        }
        else
        {
            StopCoroutine(coroutine);
        }
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.transform.CompareTag("Ball"))
    //    {
    //        animator.Play("Brick (1)", -1, float.NegativeInfinity);
    //        Destroy(this);
    //    }
    //}
}
