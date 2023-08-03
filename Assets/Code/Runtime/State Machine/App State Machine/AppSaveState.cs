using UnityEngine;
using Assets.Code.Scripts.Runtime.Save_System;
using Assets.Code.Scripts.Runtime.State_Machine;

public class AppSaveState : State
{
    private readonly ISaveLoadService saveHandler;

    public AppSaveState(ISaveLoadService saveHandler) =>
        this.saveHandler = saveHandler;

    public override void OnEnter()
    {
        base.OnEnter();

        saveHandler.Save();
    }
}