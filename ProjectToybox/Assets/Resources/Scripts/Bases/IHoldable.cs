using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HoldState
{
    None,
    StartHold,
    Holding,
    OnAction,
    EndHold,
    NonHoldable,
}
public interface IHoldable
{
    HoldState HoldState { get; set; }
    ICharacterObject Holder { get; set; }
    
    void Hold(IFieldObject target);
    void Use();
    void Release();

    void HoldableUpdate();
}
