using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PetRunNode : Node
{
    private NavMeshAgent agent;
    private Transform playerTransform;
    public PetRunNode(NavMeshAgent agent, Transform playerTransform)
    {
        this.agent = agent;
        this.playerTransform = playerTransform;
    }

    public override NodeState Evaluate()
    {
        if (playerTransform != null && playerTransform.gameObject.activeSelf == true)
        {
            agent.isStopped = false;
            agent.SetDestination(playerTransform.position);
            return NodeState.Success;
        }

        else
        {
            agent.isStopped = true;
            return NodeState.Failure;
        }
    }

}
