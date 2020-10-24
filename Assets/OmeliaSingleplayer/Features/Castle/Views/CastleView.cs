using ME.ECS;
using UnityEngine;

namespace OmeliaSingleplayer.Features.Castle.Views {
    
    using ME.ECS.Views.Providers;
    
    public class CastleView : MonoBehaviourView
    {
        
        public Vector3 StartPosition;
        public override bool applyStateJob => true;

        public override void OnInitialize()
        {
            transform.position = StartPosition;
        }
        
        public override void OnDeInitialize() {
            
        }
        
        public override void ApplyStateJob(UnityEngine.Jobs.TransformAccess transform, float deltaTime, bool immediately) {
            
        }
        
        public override void ApplyState(float deltaTime, bool immediately) {
            
        }
        
    }
    
}