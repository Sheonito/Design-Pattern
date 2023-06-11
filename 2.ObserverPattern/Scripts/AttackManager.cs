using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AttackManager : MonoBehaviour, IObserver
{
    public BattleController statusController;
    public TMP_Text attackCountText;
    private int attackCount;

    private void Start()
    {
        statusController.AddObserver(this);
    }

    public void OnNotify(string value)
    {
        attackCount += 1;
        attackCountText.text = "AttackCount: " + attackCount.ToString();
    }
}
