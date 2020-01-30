﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    Rigidbody2D myRigidBody;
    [SerializeField] float moveSpeed = 1f;


    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            myRigidBody.velocity = new Vector2(-moveSpeed, 0);
        }
        else
        {
            myRigidBody.velocity = new Vector2(moveSpeed, 0);
        }
    }


    bool IsFacingRight()
    {
        return transform.localScale.x > -1;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2((Mathf.Sign(myRigidBody.velocity.x)), 1f);
    }
}
