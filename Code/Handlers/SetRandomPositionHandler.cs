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
    
    
    public class SpawnWithRandomXComponentCreated {
        
        public SpawnWithRandomX Group;
        
        private SpawnWithRandomX _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private float ActionNode5_minX = default( System.Single );
        
        private float ActionNode5_maxX = default( System.Single );
        
        private float ActionNode5_minY = default( System.Single );
        
        private float ActionNode5_maxY = default( System.Single );
        
        private float ActionNode5_minZ = default( System.Single );
        
        private float ActionNode5_maxZ = default( System.Single );
        
        private UnityEngine.Vector3 ActionNode5_Result = default( UnityEngine.Vector3 );
        
        public SpawnWithRandomX Event {
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
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode5_minX = Group.XRange.x;
            ActionNode5_maxX = Group.XRange.y;
            ActionNode5_minY = Group.Y;
            ActionNode5_maxY = Group.Y;
            ActionNode5_minZ = Group.Z;
            ActionNode5_maxZ = Group.Z;
            // ActionNode
            while (this.DebugInfo("f78d3844-550f-4931-95da-ce9c8a5c5a1d","edbd346b-fcc2-4508-af75-9cb3d831f398", this) == 1) yield return null;
            // Visit uFrame.Actions.CreateRandoms.RandomVector3
            ActionNode5_Result = uFrame.Actions.CreateRandoms.RandomVector3(ActionNode5_minX, ActionNode5_maxX, ActionNode5_minY, ActionNode5_maxY, ActionNode5_minZ, ActionNode5_maxZ);
            // SetVariableNode
            while (this.DebugInfo("edbd346b-fcc2-4508-af75-9cb3d831f398","0e52fecd-92b1-4be7-bfb6-9a010273790b", this) == 1) yield return null;
            Group.Entity.transform.position = (UnityEngine.Vector3)ActionNode5_Result;
            yield break;
        }
    }
}
