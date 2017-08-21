using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    
    public float speed = 1f;
    public Transform Ball;
    public GameObject R;
    public GameObject L;
    public float x, y;
    

    // Use this for initialization
    void Start()
    {
    
       
    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(x, y)* Time.deltaTime);
      
        if (transform.position.x >= 8.5 && (transform.position.y <= R.transform.position.y + 2.5 && transform.position.y >= R.transform.position.y - 2.5))
        {
            x *= -1;
        }
        if (transform.position.x <= -8.5 && (transform.position.y <= L.transform.position.y + 2.5 && transform.position.y >= L.transform.position.y -2.5))
        {
            x *= -1;
        }

        if (transform.position.x >= 9 || transform.position.x <= -9)
            transform.position = Vector3.zero;

        if (transform.position.y > 6 || transform.position.y < -6)
            y *= -1;
    }
    }

