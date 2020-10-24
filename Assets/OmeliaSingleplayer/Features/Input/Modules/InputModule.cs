using ME.ECS;
using UnityEngine;

namespace OmeliaSingleplayer.Features.Input.Modules
{
    using Components; using Modules; using Systems; using Features; using Markers;

#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class InputModule : IModule, IUpdate
    {

        public World world { get; set; }

        void IModuleBase.OnConstruct()
        {
        }

        void IModuleBase.OnDeconstruct()
        {
        }

        void IUpdate.Update(in float deltaTime)
        {
            if (UnityEngine.Input.GetMouseButtonDown(0) == true)
            {
                // As usual we get ray depends on camera frustum and put it via Physics.Raycast for example
                var ray = UnityEngine.Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
                if (UnityEngine.Physics.Raycast(ray, out var hitInfo, float.MaxValue, -1) == true)
                {
                    Worlds.currentWorld.AddMarker(new MouseInputMarker() {point = hitInfo.point});
                    Debug.Log($"Send marker with mouse0 point {hitInfo.point}");
                }
            }
        }

    }
}
