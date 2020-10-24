namespace ME.ECS {

    public static partial class ComponentsInitializer {
    
        public static void InitTypeId() {
            
            CoreComponentsInitializer.InitTypeId();
            

            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Features.Core.Units.Components.IsUnit>(true);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Features.Core.Units.Components.UnitInitializer>(false);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Features.Core.Players.Components.IsPlayer>(true);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Features.Core.Players.Components.Team>(false);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Features.Core.Map.Components.IsMap>(true);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Features.Core.Map.Components.MapInitializer>(true);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Features.Core.Map.Components.SpawnPoints>(false);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Features.Castle.Components.IsCastle>(true);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Components.IsActive>(true);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Components.IsGameStarted>(true);
            WorldUtilities.InitComponentTypeId<OmeliaSingleplayer.Components.Owner>(false);

        }
        
        static partial void Init(ref ME.ECS.StructComponentsContainer structComponentsContainer) {
    
            ComponentsInitializerWorld.Setup(ComponentsInitializerWorldGen.Init);
            CoreComponentsInitializer.Init(ref structComponentsContainer);

            structComponentsContainer.Validate<OmeliaSingleplayer.Features.Core.Units.Components.IsUnit>(true);
            structComponentsContainer.Validate<OmeliaSingleplayer.Features.Core.Units.Components.UnitInitializer>(false);
            structComponentsContainer.Validate<OmeliaSingleplayer.Features.Core.Players.Components.IsPlayer>(true);
            structComponentsContainer.Validate<OmeliaSingleplayer.Features.Core.Players.Components.Team>(false);
            structComponentsContainer.Validate<OmeliaSingleplayer.Features.Core.Map.Components.IsMap>(true);
            structComponentsContainer.Validate<OmeliaSingleplayer.Features.Core.Map.Components.MapInitializer>(true);
            structComponentsContainer.Validate<OmeliaSingleplayer.Features.Core.Map.Components.SpawnPoints>(false);
            structComponentsContainer.Validate<OmeliaSingleplayer.Features.Castle.Components.IsCastle>(true);
            structComponentsContainer.Validate<OmeliaSingleplayer.Components.IsActive>(true);
            structComponentsContainer.Validate<OmeliaSingleplayer.Components.IsGameStarted>(true);
            structComponentsContainer.Validate<OmeliaSingleplayer.Components.Owner>(false);
    
        }
    
    }
    
    public static class ComponentsInitializerWorldGen {

        public static void Init(Entity entity) {


            entity.ValidateData<OmeliaSingleplayer.Features.Core.Units.Components.IsUnit>(true);
            entity.ValidateData<OmeliaSingleplayer.Features.Core.Units.Components.UnitInitializer>(false);
            entity.ValidateData<OmeliaSingleplayer.Features.Core.Players.Components.IsPlayer>(true);
            entity.ValidateData<OmeliaSingleplayer.Features.Core.Players.Components.Team>(false);
            entity.ValidateData<OmeliaSingleplayer.Features.Core.Map.Components.IsMap>(true);
            entity.ValidateData<OmeliaSingleplayer.Features.Core.Map.Components.MapInitializer>(true);
            entity.ValidateData<OmeliaSingleplayer.Features.Core.Map.Components.SpawnPoints>(false);
            entity.ValidateData<OmeliaSingleplayer.Features.Castle.Components.IsCastle>(true);
            entity.ValidateData<OmeliaSingleplayer.Components.IsActive>(true);
            entity.ValidateData<OmeliaSingleplayer.Components.IsGameStarted>(true);
            entity.ValidateData<OmeliaSingleplayer.Components.Owner>(false);

        }

    }

}