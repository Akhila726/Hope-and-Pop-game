using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int ScoreIncrementer = 0;
    [SerializeField] int collidecount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collidecount += 1;
            if(collidecount == 1)
            ScoreIncrementer = ScoreIncrementer + 5;
            Debug.Log("your score is  " + ScoreIncrementer);
            gameObject.tag = "Hit";
        }
    }
}
