using ME.ECS;
using OmeliaSingleplayer.Features.Castle.Views;

namespace OmeliaSingleplayer.Features {

    using Components; using Modules; using Systems; using Features; using Markers;
    using Castle.Components; using Castle.Modules; using Castle.Systems; using Castle.Markers;
    
    namespace Castle.Components {}
    namespace Castle.Modules {}
    namespace Castle.Systems {}
    namespace Castle.Markers {}
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class CastleFeature : Feature
    {

        public CastleView castleView;
        protected override void OnConstruct()
        {

            var viewId = this.world.RegisterViewSource(this.castleView);
            
            var castle = new Entity("Castle");
            castle.SetData(new IsCastle());
        }

        protected override void OnDeconstruct() {
            
        }

    }

}