using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class an_script : MonoBehaviour
{
    Renderer spriteRenderer;
    public float sp = 0.5f;
    void Start()
    {
        spriteRenderer= GetComponent<Renderer>();
    }

    
    void Update()
    {
        float offset=Time.time* sp;
        spriteRenderer.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
