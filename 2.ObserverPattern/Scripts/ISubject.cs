using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    public void AddObserver(IObserver observer);

    public void RemoveObserver(IObserver observer);

    public void Notify(string value);
}
