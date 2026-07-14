using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shoot_Colision : MonoBehaviour
{
    public int Scoreboard;
    public GameObject ScoreboardText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreboardText.GetComponent<TMP_Text>().text = "Pontuação: 0";
        Scoreboard = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreboardText.GetComponent<TMP_Text>().text = "Pontuação: " + Scoreboard;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Alvo"))
        {
            Destroy(collision.gameObject);
            Scoreboard++;
        }

    }
}
