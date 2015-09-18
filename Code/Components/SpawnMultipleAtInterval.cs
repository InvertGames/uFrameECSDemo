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
    
    
    [uFrame.Attributes.uFrameIdentifier("8f20ac10-5695-40e2-8ea5-8c3ec4716133")]
    public partial class SpawnMultipleAtInterval : uFrame.ECS.EcsComponent {
        
        private Subject<Transform> _ParentObservable;
        
        private Subject<Single> _SpawnSpeedObservable;
        
        [UnityEngine.SerializeField()]
        private Transform _Parent;
        
        [UnityEngine.SerializeField()]
        private Single _SpawnSpeed;
        
        [UnityEngine.SerializeField()]
        private List<GameObject> _Items;
        
        public int ComponentID {
            get {
                return 8;
            }
        }
        
        public IObservable<Transform> ParentObservable {
            get {
                if (_ParentObservable == null) {
                    _ParentObservable = new Subject<Transform>();
                }
                return _ParentObservable;
            }
        }
        
        public IObservable<Single> SpawnSpeedObservable {
            get {
                if (_SpawnSpeedObservable == null) {
                    _SpawnSpeedObservable = new Subject<Single>();
                }
                return _SpawnSpeedObservable;
            }
        }
        
        public Transform Parent {
            get {
                return _Parent;
            }
            set {
                _Parent = value;
                if (_ParentObservable != null) {
                    _ParentObservable.OnNext(value);
                }
            }
        }
        
        public Single SpawnSpeed {
            get {
                return _SpawnSpeed;
            }
            set {
                _SpawnSpeed = value;
                if (_SpawnSpeedObservable != null) {
                    _SpawnSpeedObservable.OnNext(value);
                }
            }
        }
        
        public List<GameObject> Items {
            get {
                if (_Items == null) {
                    _Items = new List<GameObject>();
                }
                return _Items;
            }
            set {
                _Items = value;
            }
        }
    }
}
