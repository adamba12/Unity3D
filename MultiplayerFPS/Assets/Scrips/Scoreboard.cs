using System.Collections;
using UnityEngine;

public class Scoreboard : MonoBehaviour {

    [SerializeField]
    GameObject playerScoreboardItem;

    [SerializeField]
    Transform playerScoreBoardList;

	void OnEnable ()
    {
		//Get an array of players
        //Loop through and set up a list for each one
        //Setting the UI elements equal to the relevant data

        Player[] players = GameManager.GetAllPlayers();

        foreach (Player player in players)
        {
            GameObject itemGO =  (GameObject) Instantiate(playerScoreboardItem, playerScoreBoardList);
            PlayerScoreboardItem item = itemGO.GetComponent<PlayerScoreboardItem>();
            if (item != null)
            {
                item.Setup(player.username, player.kills, player.deaths);
            }
        }
	}
	
    void OnDisable()
    {
        //Clean up our list of items
        foreach (Transform child in playerScoreBoardList)
        {
            Destroy(child.gameObject);
        }
    }
}
