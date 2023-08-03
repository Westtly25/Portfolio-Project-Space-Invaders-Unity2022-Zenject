using Assets.Code.Scripts.Runtime.Asset_Management;
using System;
using Zenject;

namespace Assets.Code.Runtime.Hero_System
{
    public class HeroFactory
    {
        private readonly DiContainer diContainer;
        private readonly IAssetProvider assetProvider;

        public HeroFactory(DiContainer diContainer, IAssetProvider assetProvider)
        {
            this.diContainer = diContainer;
            this.assetProvider = assetProvider;
        }


        //Load asset
        //Instantiate & inject hero 
        public void Create()
        {
            
        }
    }
}