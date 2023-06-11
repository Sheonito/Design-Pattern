using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PetSearchNode : Node
{
    private NavMeshAgent agent;
    private Transform playerTransform;
    public PetSearchNode(NavMeshAgent agent, Transform playerTransform)
    {
        this.agent = agent;
        this.playerTransform = playerTransform;
    }

    public override NodeState Evaluate()
    {
        int layerMask = 1 << LayerMask.NameToLayer("Player");
        Collider[] cols = Physics.OverlapSphere(agent.transform.position, 2, layerMask);
        if (cols.Length > 0)
            return NodeState.Success;

        else
            return NodeState.Failure;
    }
}
