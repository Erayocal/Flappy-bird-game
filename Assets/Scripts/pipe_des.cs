using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_des : MonoBehaviour
{
    private void Update()
    {
        float leftEdge = Camera.main.ScreenToViewportPoint(Vector3.zero).x - 6f;
        transform.position += Vector3.left * 3.5f * Time.deltaTime;
        if (transform.position.x < leftEdge) { Destroy(gameObject); }
    }
}
