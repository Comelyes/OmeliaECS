using ME.ECS;
using UnityEngine;

namespace OmeliaSingleplayer.Features.Input.Systems {

    #pragma warning disable
    using OmeliaSingleplayer.Components; using OmeliaSingleplayer.Modules; using OmeliaSingleplayer.Systems; using OmeliaSingleplayer.Markers;
    using Components; using Modules; using Systems; using Markers;
    #pragma warning restore
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class MarkerCheckSystem : ISystem, IAdvanceTick, IUpdate {
        
        public World world { get; set; }
        
        void ISystemBase.OnConstruct() {}
        
        void ISystemBase.OnDeconstruct() {}
        
        void IAdvanceTick.AdvanceTick(in float deltaTime) {}

        void IUpdate.Update(in float deltaTime)
        {
            /*if (this.world.GetMarker(out MouseInputMarker marker) == true) {

                UnityEngine.Debug.Log($" Marker Checked {marker.point} ") ;
                //this.feature.SendDir(dir);
            }*/
        }
            
    }
    
}