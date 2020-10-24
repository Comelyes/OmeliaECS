using ME.ECS;
using UnityEngine;

namespace OmeliaSingleplayer.Features.Core.Map.Views {
    
    using ME.ECS.Views.Providers;
    
    public class MapView : MonoBehaviourView {

        [System.Serializable]
        public struct SpawnPoint
        {
            public int teamId;
            public Transform point;
            public int unitCount;
        }

        public SpawnPoint[] spawnPoints;
        
        public override bool applyStateJob => true;

        public override void OnInitialize() {
            
        }
        
        public override void OnDeInitialize() {
            
        }
        
        public override void ApplyStateJob(UnityEngine.Jobs.TransformAccess transform, float deltaTime, bool immediately) {
            
        }
        
        public override void ApplyState(float deltaTime, bool immediately)
        {

            this.transform.position = this.entity.GetPosition();
            this.transform.rotation = this.entity.GetRotation();

        }
        
    }
    
}