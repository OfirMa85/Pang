using UnityEngine;

public class PlayerInputModel : PangElement
{
    private readonly KeyCode[] right =
    {
        KeyCode.D,
        KeyCode.RightArrow
    };
    private readonly KeyCode[] left =
    {
        KeyCode.A,
        KeyCode.LeftArrow
    };
    private readonly KeyCode[] attack =
    {
        KeyCode.W,
        KeyCode.UpArrow,
        KeyCode.Space,
        KeyCode.C
    };
    [HideInInspector]
    public bool ismovingRight;
    [HideInInspector]
    public bool ismovingLeft;
    [HideInInspector]
    public bool isAttacking;

    public bool IsMoving
    {
        get
        {
            return ismovingRight || ismovingLeft;
        }
    }

    public void UpdateInput()
    {
        ismovingRight = CheckInput(right);
        ismovingLeft = CheckInput(left);
        isAttacking = CheckInput(attack);
    }

    private bool CheckInput(KeyCode[] keys)
    {
        foreach (KeyCode key in keys)
        {
            if (Input.GetKey(key))
            {
                // pressing 'key'
                return true;
            }
        }
        // not pressing 'key'
        return false;
    }
}
