using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampToCameraBorder : MonoBehaviour
{
    public Vector2 border;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Camera.main.ScreenToWorldPoint(border * new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
