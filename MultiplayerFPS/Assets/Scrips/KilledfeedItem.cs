using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class KilledfeedItem : MonoBehaviour {

    [SerializeField]
    Text text;

    public void Setup (string player, string source)
    {
        text.text = "<b>"+source+"</b>" + " killed " + "<i>" + player + "</i>";
    }
}
