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
    
    
    public class WavesGameScorePropertyChanged {
        
        public WavesGame Group;
        
        private WavesGame _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private uFrameECSDemo.ScoreText LoopGroupNode9_Item = default( uFrameECSDemo.ScoreText );
        
        private string FormatStringAction7_Result = default( System.String );
        
        public WavesGame Event {
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
            while (this.DebugInfo("1599be78-af9c-4b2f-8109-6914c0ad665e","0d153b2b-6036-4c90-95fa-0deca9275c63", this) == 1) yield return null;
            var LoopGroupNode9_GroupComponents = System.ComponentSystem.RegisterComponent<uFrameECSDemo.ScoreText>().Components;
            for (var LoopGroupNode9_ItemIndex = 0
            ; LoopGroupNode9_ItemIndex < LoopGroupNode9_GroupComponents.Count; LoopGroupNode9_ItemIndex++
            ) {
                LoopGroupNode9_Item = LoopGroupNode9_GroupComponents[LoopGroupNode9_ItemIndex];
                System.StartCoroutine(LoopGroupNode9_Next());
            }
            yield break;
        }
        
        private System.Collections.IEnumerator LoopGroupNode9_Next() {
            // FormatStringAction
            while (this.DebugInfo("0d153b2b-6036-4c90-95fa-0deca9275c63","beb283ce-d6a3-44e3-bd9b-bf1dbfc42424", this) == 1) yield return null;
            FormatStringAction7_Result = string.Format(@"Score: {0}", Group.Score);
            // SetVariableNode
            while (this.DebugInfo("beb283ce-d6a3-44e3-bd9b-bf1dbfc42424","5d9e6255-926d-40e7-b316-d63686ca222f", this) == 1) yield return null;
            LoopGroupNode9_Item.Text.text = (System.String)FormatStringAction7_Result;
            yield break;
        }
    }
}
