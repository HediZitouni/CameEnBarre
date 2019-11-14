using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    public PlayerGoup pg;
    public string textAddPlayerButton;
    public Vector3 groupOrigin;
    public List<Player> playerList;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        groupOrigin = new Vector3(200f, 200f, 0f);
        playerList = new List<Player>();
        textAddPlayerButton = GameObject.Find("AddPlayerButton").GetComponentInChildren<Text>().text;
    }

    // Update is called once per frame
    void Update()
    {
        //textAddPlayerButton = GameObject.Find("PlayerNameInputField").GetComponentInChildren<Text>().text;
        GameObject.Find("AddPlayerButton").GetComponentInChildren<Text>().text = "Add " +
            GameObject.Find("nameEntry").GetComponent<Text>().text;
    }

    public void addPlayer(string playerName)
    {
        float x = groupOrigin.x;
        float y = groupOrigin.y - 30f * this.playerList.Count;
        Player p = Instantiate(player, new Vector3(x, y, 0f), Quaternion.identity);
        p.name = playerName;
        playerList.Add(p);
    }

    public void updateAddPlayerButton(string pseudo)
    {
        
    }
}
