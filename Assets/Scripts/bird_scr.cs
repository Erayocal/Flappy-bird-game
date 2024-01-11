using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_scr: MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    private Vector3 dir;
    public float gravity = -9.8f;
    public float sp = 5f;

    public Sprite[] sprites;
    public int spriteIndex;
    private int score = 0;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        InvokeRepeating("bird_an", 0.15f, 0.15f);
    }
    private void bird_an()
    {
        spriteIndex=(spriteIndex+1)% sprites.Length;
        spriteRenderer.sprite = sprites[spriteIndex];
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            dir += sp * Vector3.up;
        }

        dir.y += gravity * Time.deltaTime;
        transform.position += dir * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="score")
        {
            score += 1;
            Debug.Log(score);

        }
        if(collision.tag=="pipe")
        {
            Destroy(gameObject);
        }

    }


}
