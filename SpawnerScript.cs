using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SpawnerScript : MonoBehaviour
{
    float moveSpeed = 2.0f;
    Rigidbody rb;

    public GameObject coin;


  

    public GameObject leftWall;
    public GameObject rightWall;
    float leftWallPositionX;
    float rightWallPositionX;

    public GameObject scoreText;
    ScoreScript scoreS;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        leftWallPositionX = leftWall.transform.position.x;
        rightWallPositionX = rightWall.transform.position.x;

        scoreS = scoreText.GetComponent<ScoreScript>();

    }
    void Update()
    {
        Vector3 currentPosition = this.transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x,
             leftWallPositionX, rightWallPositionX);
        this.transform.position = currentPosition;


        float x = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(x, 0, 0);

        rb.velocity = direction * moveSpeed;
        if (Input.GetKeyDown("space"))
        {
            Instantiate(coin, this.transform.position, this.transform.rotation);
            scoreS.subScore(1);

        }
    }
}

   



       