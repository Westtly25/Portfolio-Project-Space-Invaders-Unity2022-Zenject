using Zenject;
using Assets.Code.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.Pause;
using Assets.Code.Scripts.Runtime.Input_System;
using Assets.Code.Scripts.Runtime.State_Machine.Gameplay_State_Machine;
using Assets.Code.Runtime.Enemies_System;
using Assets.Code.Runtime.Combat_System;

namespace Assets.Code.Scripts.Runtime.Installers
{
    public class GameplayInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameplayStateMachine>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.Bind<PlayerScore>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<PauseHandler>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<InputService>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindMemoryPool<Projectile, ProjectilesPool>()
                     .WithInitialSize(10)
                     .WithMaxSize(20);
        }
    }
}
