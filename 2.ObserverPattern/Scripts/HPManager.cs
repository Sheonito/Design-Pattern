using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HPManager : MonoBehaviour,IObserver
{
    public BattleController statusController;
    public TMP_Text hpText;
    private int hp;

    private void Start()
    {
        hp = int.Parse(hpText.text.Split(" ")[1]); 
        statusController.AddObserver(this);
    }

    public void OnNotify(string value)
    {
        int damage = int.Parse(value);
        hp -= damage;
        hpText.text = "HP: " + hp;
    }

}
