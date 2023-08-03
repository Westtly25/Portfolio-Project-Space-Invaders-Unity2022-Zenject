using System.Collections;
using Assets.Code.Scripts.Runtime.Pause;
using Assets.Code.Scripts.Runtime.Save_System;
using Assets.Code.Scripts.Runtime.State_Machine;
using Zenject;

public class AppStateMachine : StateMachine
{
    [Inject]
    public AppStateMachine(ISaveLoadService saveHandler,
                           IPauseHandler pauseHandler)
    {
        State[] states =
        {
                new AppLoadState(saveHandler),
                new AppSaveState(saveHandler),
                new AppPausedState(pauseHandler),
                new AppQuiteState()
            };

        AddStates(states);
    }
}