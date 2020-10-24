using ME.ECS;
using OmeliaSingleplayer.Features.Core.Units.Views;
using UnityEngine;

namespace OmeliaSingleplayer.Features.Core {

    using Components; using Modules; using Systems; using Features; using Markers;
    using Units.Components; using Units.Modules; using Units.Systems; using Units.Markers;
    
    namespace Units.Components {}
    namespace Units.Modules {}
    namespace Units.Systems {}
    namespace Units.Markers {}
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class UnitsFeature : Feature
    {

        public UnitView viewSource;
        public ViewId viewId;
        
        protected override void OnConstruct()
        {

            this.viewId = this.world.RegisterViewSource(this.viewSource);

            this.AddSystem<UnitSpawnSystem>();
            this.AddSystem<UnitControllerSystem>();


        }

        protected override void OnDeconstruct() {
            
        }

        

    }

}