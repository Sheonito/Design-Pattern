using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PetBehaviorTree : BehaviorTree
{
    public NavMeshAgent agent;
    public Transform playerTrnasform;
    protected override Node Init()
    {
        SequenceNode sequenceNode = new SequenceNode();
        PetIdleNode idleNode = new PetIdleNode(agent);

        PetSearchNode searchNode = new PetSearchNode(agent,playerTrnasform);
        PetRunNode runNode = new PetRunNode(agent,playerTrnasform);

        sequenceNode.AttachNode(searchNode);
        sequenceNode.AttachNode(idleNode);

        SelectorNode rootNode = new SelectorNode();
        rootNode.AttachNode(sequenceNode);
        rootNode.AttachNode(runNode);

        agent.SetDestination(playerTrnasform.position);
        return rootNode;
    }

}
