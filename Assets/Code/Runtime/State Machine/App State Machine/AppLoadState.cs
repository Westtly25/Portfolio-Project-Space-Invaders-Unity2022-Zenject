using Assets.Code.Scripts.Runtime.Save_System;
using Assets.Code.Scripts.Runtime.State_Machine;

public class AppLoadState : State
{
    private readonly ISaveLoadService saveHandler;

    public bool IsComplete => saveHandler.IsLoaded;

    public AppLoadState(ISaveLoadService saveHandler) =>
        this.saveHandler = saveHandler;

    public override void OnEnter()
    {
        base.OnEnter();

        saveHandler.Load();
    }
}