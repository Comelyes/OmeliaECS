using System.Reflection;
using ME.ECS;
using UnityEngine;

namespace OmeliaSingleplayer.Features.Core.Units.Systems {

    #pragma warning disable
    using OmeliaSingleplayer.Components; using OmeliaSingleplayer.Modules; using OmeliaSingleplayer.Systems; using OmeliaSingleplayer.Markers;
    using Components; using Modules; using Systems; using Markers;
    #pragma warning restore
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class UnitControllerSystem : ISystemFilter {
        
        public World world { get; set; }
        
        
        void ISystemBase.OnConstruct() {}
        
        void ISystemBase.OnDeconstruct() {}
        
        bool ISystemFilter.jobs => false;
        int ISystemFilter.jobsBatchCount => 64;
        Filter ISystemFilter.filter { get; set; }
        Filter ISystemFilter.CreateFilter() {
            
            return Filter.Create("Filter-UnitControllerSystem").Push();
            
        }

        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            if (this.world.GetMarker(out MouseInputMarker marker) == true) {
                
                entity.SetPosition(marker.point);
                Debug.Log($" position {marker.point}");
            }
        }
    
    }
    
}