using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorNode : Node
{
    public SelectorNode() : base() { }
    public SelectorNode(List<Node> childs) : base(childs) { }
    
    public override NodeState Evaluate()
    {
        foreach (Node node in childrenNodes)
        {
            switch (node.Evaluate())
            {
                case NodeState.Success:
                    return NodeState.Success;

                case NodeState.Failure:
                    continue;

                case NodeState.Running:
                    return NodeState.Running;
            }
        }
        return NodeState.Failure;
    }

}
