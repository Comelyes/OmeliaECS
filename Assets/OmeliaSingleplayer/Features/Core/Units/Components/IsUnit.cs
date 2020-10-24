using ME.ECS;

namespace OmeliaSingleplayer.Features.Core.Units.Components {

    public struct IsUnit : IStructComponent {
    }

    public struct UnitInitializer : IStructComponent
    {

        public RefEntity owner;

    }

}