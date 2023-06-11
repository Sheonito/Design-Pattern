using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveNode : Node
{
    private MoveVector moveVector;
    private CharacterController cc;
    private float speed;

    public PlayerMoveNode(CharacterController controller, MoveVector moveVector)
    {
        speed = 3;
        cc = controller;
        this.moveVector = moveVector;
    }

    public override NodeState Evaluate()
    {
        if (moveVector.dir != Vector3.zero)
        {
            cc.Move(moveVector.dir * speed * Time.deltaTime);
            return NodeState.Success;
        }
        else
        {
            return NodeState.Failure;
        }
    }

}
