using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class SaucerScript : MonoBehaviour
    {
        public GameObject scoreText;
        ScoreScript scoreS;

        void Start()
        {
            scoreS = scoreText.GetComponent<ScoreScript>();
        }
        void OnCollisionEnter(Collision colObject)
    {
        if (colObject.gameObject.tag == "Coin")
        {
            Destroy(colObject.gameObject);
            scoreS.addScore(2);
        }
    }
}

