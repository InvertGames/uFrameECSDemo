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
    
    
    public class WavesGameCreatedComponentCreated {
        
        public WavesGame Group;
        
        private WavesGame _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private int IntNode18 = 0;
        
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
            // SetVariableNode
            while (this.DebugInfo("d8e16c6c-ac06-4dbc-8454-364f53870ee7","7acc43ed-c009-4cf2-9b24-6035e784d2b8", this) == 1) yield return null;
            Group.Score = (System.Int32)IntNode18;
            yield break;
        }
    }
}
