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
    using uFrameECSDemo;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    public partial class Gunner : uFrame.ECS.EcsComponent {
        
        private List<Gun> _Guns;
        
        public int ComponentID {
            get {
                return 10;
            }
        }
        
        public List<Gun> Guns {
            get {
                if (_Guns == null) {
                    _Guns = new List<Gun>();
                }
                return _Guns;
            }
            set {
                _Guns = value;
            }
        }
    }
}
