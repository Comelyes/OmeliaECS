using ME.ECS;

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
    public sealed class UnitSpawnSystem : ISystemFilter
    {

        public UnitsFeature feature;
        
        public World world { get; set; }

        void ISystemBase.OnConstruct()
        {
            this.feature = this.world.GetFeature<UnitsFeature>();

        }
        
        void ISystemBase.OnDeconstruct() {}
        
        bool ISystemFilter.jobs => false;
        int ISystemFilter.jobsBatchCount => 64;
        Filter ISystemFilter.filter { get; set; }
        Filter ISystemFilter.CreateFilter() {
            
            return Filter.Create("Filter-UnitSpawnSystem")
                .WithStructComponent<UnitInitializer>()
                .Push();
            
        }

        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            var init = entity.GetData<UnitInitializer>();
            entity.SetData(new Owner() { value = init.owner });
            entity.InstantiateView(this.feature.viewId);

        }
    
    }
    
}