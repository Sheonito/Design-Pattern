using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PetIdleNode : Node
{
    private NavMeshAgent agent;
    public PetIdleNode(NavMeshAgent agent)
    {
        this.agent = agent;
    }

    public override NodeState Evaluate()
    {
        agent.isStopped = true;
        return NodeState.Success;
    }

}
