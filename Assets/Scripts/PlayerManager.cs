using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject playerPrefab;
    public RectTransform currentTransform;
    
    public Dictionary<string, GameObject> playerDictionnary;
    // Start is called before the first frame update
    void Start()
    {
        playerDictionnary = new Dictionary<string, GameObject>();
        currentTransform = playerPrefab.transform.Find("Canvas").Find("Spawn").gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addNewPlayer(string pseudo)
    {
        
        GameObject newPlayer = Instantiate(playerPrefab, playerPrefab.transform);
        playerDictionnary.Add(pseudo, newPlayer);
        Debug.Log(pseudo);
    }
}
