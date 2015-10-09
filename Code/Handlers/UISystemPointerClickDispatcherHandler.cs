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
    
    
    public class UISystemPointerClickDispatcherHandler {
        
        public PlayGameButton Source;
        
        private uFrame.ECS.PointerClickDispatcher _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject LoopCollectionNode25_Item = default( UnityEngine.GameObject );
        
        private UnityEngine.GameObject ActionNode26_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.Vector3 ActionNode26_position = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode26_rotation = default( UnityEngine.Vector3 );
        
        private UnityEngine.GameObject ActionNode26_Result = default( UnityEngine.GameObject );
        
        public uFrame.ECS.PointerClickDispatcher Event {
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
            // LoopCollectionNode
            for (var LoopCollectionNode25_ItemIndex = 0
            ; LoopCollectionNode25_ItemIndex < Source.InstantiateItems.Count; LoopCollectionNode25_ItemIndex++
            ) {
                LoopCollectionNode25_Item = Source.InstantiateItems[LoopCollectionNode25_ItemIndex];
                LoopCollectionNode25_Next();
            }
        }
        
        private void LoopCollectionNode25_Next() {
            ActionNode26_gameObject = LoopCollectionNode25_Item;
            // ActionNode
            // Visit uFrame.Actions.GameObjects.Instantiate
            ActionNode26_Result = uFrame.Actions.GameObjects.Instantiate(ActionNode26_gameObject, ActionNode26_position, ActionNode26_rotation);
        }
    }
}
