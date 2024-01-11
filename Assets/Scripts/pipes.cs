using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{

    public GameObject pipe;

    private void OnEnable()
    {
        InvokeRepeating(nameof(createpipe), 1f, 1f);
    }

    private void createpipe()
    {
        GameObject g=Instantiate(pipe, transform.position,Quaternion.identity);
        g.transform.position += Vector3.up * Random.Range(1f, -1f);

    }
    
}
