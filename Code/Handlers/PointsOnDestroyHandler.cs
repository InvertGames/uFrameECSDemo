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
    
    
    public class PointsOnDestroyComponentDestroyed {
        
        public PointsOnDestroy Group;
        
        private PointsOnDestroy _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private uFrameECSDemo.WavesGame LoopGroupNode10_Item = default( uFrameECSDemo.WavesGame );
        
        private int ActionNode0_a = default( System.Int32 );
        
        private int ActionNode0_b = default( System.Int32 );
        
        private int ActionNode0_Result = default( System.Int32 );
        
        public PointsOnDestroy Event {
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
            // LoopGroupNode
            while (this.DebugInfo("42976861-8c91-41e7-9188-a0de2f8a460d","7a0295f2-d6fd-4fdf-8694-67691506652b", this) == 1) yield return null;
            var LoopGroupNode10_GroupComponents = System.ComponentSystem.RegisterComponent<uFrameECSDemo.WavesGame>().Components;
            for (var LoopGroupNode10_ItemIndex = 0
            ; LoopGroupNode10_ItemIndex < LoopGroupNode10_GroupComponents.Count; LoopGroupNode10_ItemIndex++
            ) {
                LoopGroupNode10_Item = LoopGroupNode10_GroupComponents[LoopGroupNode10_ItemIndex];
                System.StartCoroutine(LoopGroupNode10_Next());
            }
            yield break;
        }
        
        private System.Collections.IEnumerator LoopGroupNode10_Next() {
            ActionNode0_a = LoopGroupNode10_Item.Score;
            ActionNode0_b = Group.Points;
            // ActionNode
            while (this.DebugInfo("7a0295f2-d6fd-4fdf-8694-67691506652b","3badd76a-ede2-4bf8-98bd-6242bf285142", this) == 1) yield return null;
            // Visit uFrame.Actions.IntLibrary.Add
            ActionNode0_Result = uFrame.Actions.IntLibrary.Add(ActionNode0_a, ActionNode0_b);
            // SetVariableNode
            while (this.DebugInfo("3badd76a-ede2-4bf8-98bd-6242bf285142","28b81b2d-3039-4b03-9424-6fb8bb4421d6", this) == 1) yield return null;
            LoopGroupNode10_Item.Score = (System.Int32)ActionNode0_Result;
            yield break;
        }
    }
}
