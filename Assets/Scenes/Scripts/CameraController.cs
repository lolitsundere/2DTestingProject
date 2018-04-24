using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
    public float rollingSpeed = 1f;
    public Transform tf;
    // Use this for initialization

    private Camera camera;

    void Start ()
    {
        tf = transform;
        camera = tf.GetComponent<Camera>();
	}

    /*
    private void FixedUpdate()
    {
        Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero, 100f, LayerMask.GetMask("MouseHitable"));
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.name);
        }
    }
    */

    // Update is called once per frame
    void Update ()
    {
        //缩放
        var scrollingSize = camera.orthographicSize - Input.mouseScrollDelta.y;
        if (scrollingSize > 2 && scrollingSize < 17)
        {
            camera.orthographicSize = scrollingSize;
        }

        //滚动
        if (Application.isFocused)
        {
            float x = Input.mousePosition.x;
            float y = Input.mousePosition.y;
            if (x < 10 && x >= 0)
            {
                CameraMovingLeft();
            }

            if (y < 10 && y >= 0)
            {
                CameraMovingDown();
            }

            if (x > Screen.width - 10 && x <= Screen.width)
            {
                CameraMovingRight();
            }

            if (y > Screen.height - 10 && y <= Screen.height) 
            {
                CameraMovingUp();
            }
        }
	}

    public void CameraMovingLeft()
    {
        tf.position += new Vector3(-rollingSpeed * Time.deltaTime,0f, 0f);
    }

    public void CameraMovingRight()
    {
        tf.position += new Vector3(rollingSpeed * Time.deltaTime, 0f, 0f);
    }

    public void CameraMovingUp()
    {
        tf.position += new Vector3(0f, rollingSpeed * Time.deltaTime, 0f);
    }

    public void CameraMovingDown()
    {
        tf.position += new Vector3(0f, -rollingSpeed * Time.deltaTime, 0f);
    }
}
