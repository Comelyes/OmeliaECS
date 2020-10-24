using ME.ECS;
using OmeliaSingleplayer.Features.Core.Map.Components;
using OmeliaSingleplayer.Features.Core.Units.Components;
using UnityEngine;

namespace OmeliaSingleplayer.Features.Core.Players.Systems {

    #pragma warning disable
    using OmeliaSingleplayer.Components; using OmeliaSingleplayer.Modules; using OmeliaSingleplayer.Systems; using OmeliaSingleplayer.Markers;
    using Components; using Modules; using Systems; using Markers;
    #pragma warning restore
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class StartGameSystem : ISystemFilter
    {

        private MapFeature mapFeature;
        private Filter players;
        
        public World world { get; set; }

        void ISystemBase.OnConstruct()
        {

            this.mapFeature = this.world.GetFeature<MapFeature>();
            
            Filter.Create("Filter-StartGameSystem-Players")
                .WithStructComponent<IsPlayer>()
                .Push(ref this.players);
        }
        
        void ISystemBase.OnDeconstruct() {}
        
        bool ISystemFilter.jobs => false;
        int ISystemFilter.jobsBatchCount => 64;
        Filter ISystemFilter.filter { get; set; }
        Filter ISystemFilter.CreateFilter() {
            
            return Filter.Create("Filter-StartGameSystem")
                .WithStructComponent<IsGameStarted>()
                .Push();
            
        }

        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            foreach (var player in this.players)
            {
                var teamId = player.GetData<Team>().value;
                var sp = this.mapFeature.map.GetData<SpawnPoints>();
                for (int i = 0; i < sp.value.Length; ++i)
                {
                    if (sp.value[i].teamId == teamId)
                    {
                        this.CreateUnits(player, sp.value[i].point.position, sp.value[i].unitCount);
                        break;
                    }
                }

            }
            
            
        }

        private void CreateUnits(Entity owner, Vector3 position, int count)
        {
            for (int i = 0; i < count; ++i)
            {

                var unit = new Entity("Unit");
                unit.SetData(new IsUnit());
                unit.SetData(new UnitInitializer()
                {
                    owner = new RefEntity(owner),
                }, ComponentLifetime.NotifyAllSystems);
                unit.SetPosition(position);

            }

        }
    
    }
    
}