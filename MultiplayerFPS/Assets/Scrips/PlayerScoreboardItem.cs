using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreboardItem : MonoBehaviour {


    [SerializeField]
    Text usernameText;

    [SerializeField]
    Text killsText;

    [SerializeField]
    Text deathText;

    public void Setup (string username, int kills, int deaths)
    {
        usernameText.text = username;
        killsText.text = "Kills: " + kills;
        deathText.text = "Daaths: " + deaths;
    }
}
