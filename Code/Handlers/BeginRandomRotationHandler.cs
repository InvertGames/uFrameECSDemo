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
    using UnityEngine;
    using uFrame.Kernel;
    
    
    public class RandomRotationComponentCreated {
        
        public RandomRotation Group;
        
        private RandomRotation _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode4_go = default( UnityEngine.GameObject );
        
        private UnityEngine.MonoBehaviour ActionNode4_component = default( UnityEngine.MonoBehaviour );
        
        private UnityEngine.Rigidbody ActionNode4_Result = default( UnityEngine.Rigidbody );
        
        private UnityEngine.Vector3 ActionNode0_Result = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode6_a = default( UnityEngine.Vector3 );
        
        private float ActionNode6_b = default( System.Single );
        
        private UnityEngine.Vector3 ActionNode6_Result = default( UnityEngine.Vector3 );
        
        public RandomRotation Event {
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
            ActionNode4_go = Group.Entity.gameObject;
            // ActionNode
            // Visit uFrame.Actions.UnityLibrary.GetRigidbody
            ActionNode4_Result = uFrame.Actions.UnityLibrary.GetRigidbody(ActionNode4_go, ActionNode4_component);
            // ActionNode
            // Visit uFrame.Actions.CreateRandoms.GetInsideSphere
            ActionNode0_Result = uFrame.Actions.CreateRandoms.GetInsideSphere();
            ActionNode6_a = ActionNode0_Result;
            ActionNode6_b = Group.Tumble;
            // ActionNode
            // Visit uFrame.Actions.Vector3Library.Multiply
            ActionNode6_Result = uFrame.Actions.Vector3Library.Multiply(ActionNode6_a, ActionNode6_b);
            // SetVariableNode
            ActionNode4_Result.angularVelocity = (UnityEngine.Vector3)ActionNode6_Result;
        }
    }
}