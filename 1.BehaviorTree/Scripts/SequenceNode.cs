using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceNode : Node
{
    // ������ �����ڸ� ȣ��
    public SequenceNode() : base() { }

    // �θ��� �����ڸ� ȣ��
    public SequenceNode(List<Node> childs) : base(childs) { }

    public override NodeState Evaluate()
    {
        bool isRunning = false;
        foreach (Node node in childrenNodes)
        {
            switch (node.Evaluate())
            {
                case NodeState.Success:
                    continue;

                case NodeState.Failure:
                    return NodeState.Failure;

                case NodeState.Running:
                    isRunning = true;
                    continue;
            }
        }
        return isRunning ? NodeState.Running : NodeState.Success;
    }

}
