using ME.ECS;

namespace OmeliaSingleplayer.Features.Core {

    using Components; using Modules; using Systems; using Features; using Markers;
    using Players.Components; using Players.Modules; using Players.Systems; using Players.Markers;
    
    namespace Players.Components {}
    namespace Players.Modules {}
    namespace Players.Systems {}
    namespace Players.Markers {}
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class PlayersFeature : Feature
    {

        public Entity activePlayer;
        
        protected override void OnConstruct()
        {

            var myPlayer = this.CreatePlayer(1, 1);
            myPlayer.SetData(new IsActive());
            this.activePlayer = myPlayer;
            
            this.CreatePlayer(2, 2);

            this.AddSystem<StartGameSystem>();

        }

        protected override void OnDeconstruct() {
            
        }

        public Entity CreatePlayer(int actorId, int teamId)
        {
            
            var player = new Entity("Player" + actorId);
            player.SetData(new IsPlayer());
            player.SetData(new Team() { value = teamId });

            return player;

        }

    }

}