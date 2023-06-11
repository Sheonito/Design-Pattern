using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour,IObserver
{
    public TMP_Text log;
    public Button attackButton;
    public BattleController battleController;
    private void Start()
    {
        battleController.AddObserver(this);
    }

    public void OnNotify(string value)
    {
        int damage = int.Parse(value);
        if (damage == 5)
        {
            log.text = "You got a critical damage. You die...";
            attackButton.interactable = false;
        }

    }

}
