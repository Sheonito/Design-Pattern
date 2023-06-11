using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeState
{
    Success,
    Failure,
    Running,
}

public abstract class Node
{
    protected NodeState state;
    public Node parentNode;
    protected List<Node> childrenNodes = new List<Node>();

    public Node()
    { 
    
    }

    public Node(List<Node> children)
    {
        for (int i = 0; i < children.Count; i++)
        {
            AttachNode(children[i]);
        }
    }

    public void AttachNode(Node node)
    {
        childrenNodes.Add(node);
        node.parentNode = node;
    }

    public abstract NodeState Evaluate();
}
