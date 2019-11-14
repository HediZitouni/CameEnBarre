using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    public int round;
    private Text textRoundNumber;
    // Start is called before the first frame update
    void Start()
    {
        round = 1;
        textRoundNumber = GameObject.Find("RoundNumber").GetComponent<Text>();
        displayRound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextRound()
    {
        round++;
        displayRound();
    }

    public void previousRound()
    {
        round--;
        displayRound();
    }

    public void displayRound()
    {
        textRoundNumber.text = "Rounds : " + round.ToString();
    }
}
