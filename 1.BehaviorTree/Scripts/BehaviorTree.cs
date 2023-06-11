using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BehaviorTree : MonoBehaviour
{
    private Node rootNode;

    protected virtual void Start()
    {
        rootNode = Init();
    }

    protected virtual void Update()
    {
        if (rootNode != null)
            rootNode.Evaluate();
    }

    protected abstract Node Init();

}
