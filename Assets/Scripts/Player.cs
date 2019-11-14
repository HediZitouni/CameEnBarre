using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int coins;
    public string playerName;
    public Text textPlayerName;
    public Text textPlayerCoin;
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        displayPlayeName();
        dislayPlayerCoins();
    }

    // Update is called once per frame
    void Update()
    {
        dislayPlayerCoins();
    }

    public void addCoin()
    {
        coins++;
        dislayPlayerCoins();
    }
    
    public void removeCoin()
    {
        coins--;
        dislayPlayerCoins();
    }

    void displayPlayeName()
    {
        textPlayerName.text = playerName;
    }

    void dislayPlayerCoins()
    {
        textPlayerCoin.text = ": " + coins.ToString();
    }
}
