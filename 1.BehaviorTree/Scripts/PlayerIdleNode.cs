using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleNode : Node
{
    public override NodeState Evaluate()
    {
        return NodeState.Success;
    }

}
