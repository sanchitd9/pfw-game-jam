using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootScript : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float newXpos = transform.position.x + deltaX;
        transform.position = new Vector2(newXpos, transform.position.y);
    }
}
