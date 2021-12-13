using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformObject : MonoBehaviour
{
    public Vector3 pos;
    public int s;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        s = Random.Range(1, 3);
        Debug.Log(s);
        if (s == 1)
            pos.x = Random.Range(300, 700);
        else
            pos.z = Random.Range(500, 700);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
