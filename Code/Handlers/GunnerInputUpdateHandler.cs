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
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class GunnerInputUpdateHandler {
        
        public LocalGunner Group;
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.KeyCode ActionNode50_key = default( UnityEngine.KeyCode );
        
        private UnityEngine.KeyCode EnumValueNode1 = KeyCode.Space;
        
        private bool ActionNode50_Result = default( System.Boolean );
        
        private uFrameECSDemo.Gun LoopCollectionNode5_Item = default( uFrameECSDemo.Gun );
        
        private uFrameECSDemo.GunState EnumValueNode10 = GunState.Shooting;
        
        private UnityEngine.KeyCode ActionNode60_key = default( UnityEngine.KeyCode );
        
        private bool ActionNode60_Result = default( System.Boolean );
        
        private uFrameECSDemo.Gun LoopCollectionNode6_Item = default( uFrameECSDemo.Gun );
        
        private uFrameECSDemo.GunState EnumValueNode9 = GunState.Idle;
        
        public uFrame.ECS.ISystemUpdate Event {
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
            ActionNode50_key = EnumValueNode1;
            // Visit uFrame.Actions.InputLibrary.IsKeyDown
            while (this.DebugInfo("34e53f1a-79a2-4a0a-a8e3-d70477e3f946", this) == 1) yield return new WaitForEndOfFrame();
            ActionNode50_Result = uFrame.Actions.InputLibrary.IsKeyDown(ActionNode50_key, ()=> { System.StartCoroutine(ActionNode50_yes()); }, ()=> { System.StartCoroutine(ActionNode50_no()); });
            ActionNode60_key = EnumValueNode1;
            // Visit uFrame.Actions.InputLibrary.IsKeyUp
            while (this.DebugInfo("e1e48f41-ede7-4e74-9870-a2fa66b3c4af", this) == 1) yield return new WaitForEndOfFrame();
            ActionNode60_Result = uFrame.Actions.InputLibrary.IsKeyUp(ActionNode60_key, ()=> { System.StartCoroutine(ActionNode60_yes()); }, ()=> { System.StartCoroutine(ActionNode60_no()); });
            // HANDLER: GunnerInputUpdate
            yield break;
        }
        
        private System.Collections.IEnumerator LoopCollectionNode5_Next() {
            LoopCollectionNode5_Item.State = (uFrameECSDemo.GunState)EnumValueNode10;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode50_yes() {
            // Loop Collection
            for (var LoopCollectionNode5_ItemIndex = 0
            ; LoopCollectionNode5_ItemIndex < Group.Gunner.Guns.Count; LoopCollectionNode5_ItemIndex++
            ) {
                LoopCollectionNode5_Item = Group.Gunner.Guns[LoopCollectionNode5_ItemIndex];
                System.StartCoroutine(LoopCollectionNode5_Next());
            }
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode50_no() {
            yield break;
        }
        
        private System.Collections.IEnumerator LoopCollectionNode6_Next() {
            LoopCollectionNode6_Item.State = (uFrameECSDemo.GunState)EnumValueNode9;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode60_yes() {
            // Loop Collection
            for (var LoopCollectionNode6_ItemIndex = 0
            ; LoopCollectionNode6_ItemIndex < Group.Gunner.Guns.Count; LoopCollectionNode6_ItemIndex++
            ) {
                LoopCollectionNode6_Item = Group.Gunner.Guns[LoopCollectionNode6_ItemIndex];
                System.StartCoroutine(LoopCollectionNode6_Next());
            }
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode60_no() {
            yield break;
        }
    }
}
