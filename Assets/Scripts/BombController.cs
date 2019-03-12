using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {

    public float BombTimer;
    private bool BombCountDown;
    CircleCollider2D BombRadius;

    // Use this for initialization
    void Start()
    {

        BombRadius = gameObject.GetComponent<CircleCollider2D>();
        BombRadius.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (BombTimer <= 0f)
        {

            BombRadius.enabled = true;

        }


        if (BombRadius.enabled == true)
        {

            BombRadius.radius += 0.01f;


        }

        if (BombRadius.radius >= 2.90f)
        {
            //end of explosion 
            BombRadius.enabled = false;
            Destroy(gameObject);

        }



        if (BombCountDown == true)
        {


            BombTimer -= 0.05f;

        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            BombCountDown = true;

        }
    }
}

