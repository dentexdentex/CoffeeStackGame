using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float swipeSpeed;
    public float moveSpeed;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;            
    }

    void Update()
    {
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        Move();
    }

    private void Move()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = touch.deltaPosition / 1.5f;
            Vector3 newpos = new Vector3(touchPos.x, 0, 0);
            print(newpos);
            transform.position = Vector3.Lerp(transform.position, transform.position + newpos, 0.1f);
        }

       
    }
}
