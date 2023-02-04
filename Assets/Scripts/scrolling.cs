using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour
{
    public float horizontal_speed = 0f;
    public float vertical_speed = -0.2f;
    private Renderer re;

    // Start is called before the first frame update
    void Start()
    {
        re = GetComponent<Renderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * horizontal_speed, Time.time * vertical_speed);
        re.material.mainTextureOffset = offset;
    }
}
