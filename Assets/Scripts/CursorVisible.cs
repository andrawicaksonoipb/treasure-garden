using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisible : MonoBehaviour
{

    public static bool visible;
    // Start is called before the first frame update
    void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
