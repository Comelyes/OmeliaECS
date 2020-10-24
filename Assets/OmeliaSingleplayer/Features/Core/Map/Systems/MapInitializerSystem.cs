using ME.ECS;
using UnityEngine;

namespace OmeliaSingleplayer.Features.Core.Map.Systems {

    #pragma warning disable
    using OmeliaSingleplayer.Components; using OmeliaSingleplayer.Modules; using OmeliaSingleplayer.Systems; using OmeliaSingleplayer.Markers;
    using Components; using Modules; using Systems; using Markers;
    #pragma warning restore
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class MapInitializerSystem : ISystemFilter {
        
        public World world { get; set; }
        
        void ISystemBase.OnConstruct() {}
        
        void ISystemBase.OnDeconstruct() {}
        
        bool ISystemFilter.jobs => false;
        int ISystemFilter.jobsBatchCount => 64;
        Filter ISystemFilter.filter { get; set; }
        Filter ISystemFilter.CreateFilter() {
            
            return Filter.Create("Filter-MapInitializerSystem").WithStructComponent<MapInitializer>().Push(); // 1 
            
        }

        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            // init
            entity.SetPosition(new Vector3(10f, 0f, 10f));
            entity.SetRotation(Quaternion.identity);
            
            this.world.SetSharedData(new IsGameStarted(), ComponentLifetime.NotifyAllSystems);
            
            Debug.Log("Map init complete");
        }
    
    }
    
}