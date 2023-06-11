using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BattleController : MonoBehaviour, ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string value)
    {
        for (int i = 0; i < observers.Count; i++)
        {
            observers[i].OnNotify(value);
        }
    }

    public void OnClickAttack()
    {
        int damage = Random.Range(1,6);
        Notify(damage.ToString());
    }
}
