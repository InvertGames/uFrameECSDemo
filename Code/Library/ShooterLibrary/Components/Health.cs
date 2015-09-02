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
    using uFrame.ECS;
    using UniRx;
    
    
    public partial class Health : uFrame.ECS.EcsComponent {
        
        private Subject<Int32> _ValueObservable;
        
        [UnityEngine.SerializeField()]
        private Int32 _Value;
        
        public int ComponentID {
            get {
                return 5;
            }
        }
        
        public IObservable<Int32> ValueObservable {
            get {
                if (_ValueObservable == null) {
                    _ValueObservable = new Subject<Int32>();
                }
                return _ValueObservable;
            }
        }
        
        public Int32 Value {
            get {
                return _Value;
            }
            set {
                _Value = value;
                if (_ValueObservable != null) {
                    _ValueObservable.OnNext(value);
                }
            }
        }
    }
}
