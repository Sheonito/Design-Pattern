using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class MoveVector
{
    public Vector3 dir;
}

public class PlayerBehaviorTree : BehaviorTree
{
    public CharacterController cc;
    private MoveVector moveVector;
    protected override Node Init()
    {
        SelectorNode selectorNode = new SelectorNode();
        PlayerIdleNode idleNode = new PlayerIdleNode();

        moveVector = new MoveVector();
        PlayerMoveNode moveNode = new PlayerMoveNode(cc, moveVector);

        selectorNode.AttachNode(moveNode);
        selectorNode.AttachNode(idleNode);

        return selectorNode;
    }

    public void OnMove(CallbackContext value)
    {
        Vector2 inputVector = value.ReadValue<Vector2>();
        moveVector.dir = new Vector3(inputVector.x, 0, inputVector.y);
    }

}
