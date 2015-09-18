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
    using UniRx;
    using uFrame.ECS;
    
    
    [uFrame.Attributes.uFrameIdentifier("9784e33b-b2d5-4aeb-ac8b-9273187d7c8b")]
    public partial class WavesGameSystem : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<SpawnAtInterval> _SpawnAtIntervalManager;
        
        private IEcsComponentManagerOf<WavesGame> _WavesGameManager;
        
        private IEcsComponentManagerOf<SpawnMultipleAtInterval> _SpawnMultipleAtIntervalManager;
        
        private IEcsComponentManagerOf<PointsOnDestroy> _PointsOnDestroyManager;
        
        private SpawnMultipleAtIntervalComponentCreated SpawnMultipleAtIntervalComponentCreatedInstance = new SpawnMultipleAtIntervalComponentCreated();
        
        private WavesGameComponentCreated WavesGameComponentCreatedInstance = new WavesGameComponentCreated();
        
        private PointsOnDestroyComponentDestroyed PointsOnDestroyComponentDestroyedInstance = new PointsOnDestroyComponentDestroyed();
        
        private SpawnAtIntervalComponentCreated SpawnAtIntervalComponentCreatedInstance = new SpawnAtIntervalComponentCreated();
        
        public IEcsComponentManagerOf<SpawnAtInterval> SpawnAtIntervalManager {
            get {
                return _SpawnAtIntervalManager;
            }
            set {
                _SpawnAtIntervalManager = value;
            }
        }
        
        public IEcsComponentManagerOf<WavesGame> WavesGameManager {
            get {
                return _WavesGameManager;
            }
            set {
                _WavesGameManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SpawnMultipleAtInterval> SpawnMultipleAtIntervalManager {
            get {
                return _SpawnMultipleAtIntervalManager;
            }
            set {
                _SpawnMultipleAtIntervalManager = value;
            }
        }
        
        public IEcsComponentManagerOf<PointsOnDestroy> PointsOnDestroyManager {
            get {
                return _PointsOnDestroyManager;
            }
            set {
                _PointsOnDestroyManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            SpawnAtIntervalManager = ComponentSystem.RegisterComponent<SpawnAtInterval>();
            WavesGameManager = ComponentSystem.RegisterComponent<WavesGame>();
            SpawnMultipleAtIntervalManager = ComponentSystem.RegisterComponent<SpawnMultipleAtInterval>();
            PointsOnDestroyManager = ComponentSystem.RegisterComponent<PointsOnDestroy>();
            SpawnMultipleAtIntervalManager.CreatedObservable.Subscribe(SpawnMultipleAtIntervalComponentCreatedFilter).DisposeWith(this);
            WavesGameManager.CreatedObservable.Subscribe(WavesGameComponentCreatedFilter).DisposeWith(this);
            PointsOnDestroyManager.RemovedObservable.Subscribe(_=>PointsOnDestroyComponentDestroyed(_,_)).DisposeWith(this);
            SpawnAtIntervalManager.CreatedObservable.Subscribe(SpawnAtIntervalComponentCreatedFilter).DisposeWith(this);
        }
        
        protected void SpawnMultipleAtIntervalComponentCreated(SpawnMultipleAtInterval data, SpawnMultipleAtInterval group) {
            var handler = SpawnMultipleAtIntervalComponentCreatedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void SpawnMultipleAtIntervalComponentCreatedFilter(SpawnMultipleAtInterval data) {
            var GroupSpawnMultipleAtInterval = SpawnMultipleAtIntervalManager[data.EntityId];
            if (GroupSpawnMultipleAtInterval == null) {
                return;
            }
            this.SpawnMultipleAtIntervalComponentCreated(data, GroupSpawnMultipleAtInterval);
        }
        
        protected void WavesGameComponentCreated(WavesGame data, WavesGame group) {
            var handler = WavesGameComponentCreatedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void WavesGameComponentCreatedFilter(WavesGame data) {
            var GroupWavesGame = WavesGameManager[data.EntityId];
            if (GroupWavesGame == null) {
                return;
            }
            this.WavesGameComponentCreated(data, GroupWavesGame);
        }
        
        protected void PointsOnDestroyComponentDestroyed(PointsOnDestroy data, PointsOnDestroy group) {
            var handler = PointsOnDestroyComponentDestroyedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void PointsOnDestroyComponentDestroyedFilter(PointsOnDestroy data) {
            var GroupPointsOnDestroy = PointsOnDestroyManager[data.EntityId];
            if (GroupPointsOnDestroy == null) {
                return;
            }
            this.PointsOnDestroyComponentDestroyed(data, GroupPointsOnDestroy);
        }
        
        protected void SpawnAtIntervalComponentCreated(SpawnAtInterval data, SpawnAtInterval group) {
            var handler = SpawnAtIntervalComponentCreatedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void SpawnAtIntervalComponentCreatedFilter(SpawnAtInterval data) {
            var GroupSpawnAtInterval = SpawnAtIntervalManager[data.EntityId];
            if (GroupSpawnAtInterval == null) {
                return;
            }
            this.SpawnAtIntervalComponentCreated(data, GroupSpawnAtInterval);
        }
    }
}
