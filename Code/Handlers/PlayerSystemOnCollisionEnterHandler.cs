// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class PlayerSystemOnCollisionEnterHandler {
        
        public Hazard Collider;
        
        public PlayerGunner Source;
        
        private uFrame.ECS.OnTriggerEnterDispatcher _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode17_gameObject = default( UnityEngine.GameObject );
        
        private float ActionNode17_time = default( System.Single );
        
        public uFrame.ECS.OnTriggerEnterDispatcher Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual void Execute() {
            ActionNode17_gameObject = Collider.Entity.gameObject;
            // ActionNode
            // Visit uFrame.Actions.DestroyLibrary.DestroyGameObject
            uFrame.Actions.DestroyLibrary.DestroyGameObject(ActionNode17_gameObject, ActionNode17_time);
        }
    }
}
