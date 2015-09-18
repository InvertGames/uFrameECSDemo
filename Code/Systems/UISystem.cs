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
    using uFrame.ECS;
    using uFrame.Kernel;
    using UniRx;
    
    
    [uFrame.Attributes.uFrameIdentifier("b60e9496-5928-483d-b9ee-4e5ae99f0445")]
    public partial class UISystem : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<SpawnAtInterval> _SpawnAtIntervalManager;
        
        private IEcsComponentManagerOf<SpawnMultipleAtInterval> _SpawnMultipleAtIntervalManager;
        
        private IEcsComponentManagerOf<PointsOnDestroy> _PointsOnDestroyManager;
        
        private IEcsComponentManagerOf<WavesGame> _WavesGameManager;
        
        private WavesGameScorePropertyChanged WavesGameScorePropertyChangedInstance = new WavesGameScorePropertyChanged();
        
        public IEcsComponentManagerOf<SpawnAtInterval> SpawnAtIntervalManager {
            get {
                return _SpawnAtIntervalManager;
            }
            set {
                _SpawnAtIntervalManager = value;
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
        
        public IEcsComponentManagerOf<WavesGame> WavesGameManager {
            get {
                return _WavesGameManager;
            }
            set {
                _WavesGameManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            SpawnAtIntervalManager = ComponentSystem.RegisterComponent<SpawnAtInterval>();
            SpawnMultipleAtIntervalManager = ComponentSystem.RegisterComponent<SpawnMultipleAtInterval>();
            PointsOnDestroyManager = ComponentSystem.RegisterComponent<PointsOnDestroy>();
            WavesGameManager = ComponentSystem.RegisterComponent<WavesGame>();
            this.PropertyChanged<WavesGame,Int32>(Group=>Group.ScoreObservable, WavesGameScorePropertyChangedFilter);
        }
        
        protected void WavesGameScorePropertyChanged(WavesGame data, WavesGame group, Int32 value) {
            var handler = WavesGameScorePropertyChangedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void WavesGameScorePropertyChangedFilter(WavesGame data, Int32 value) {
            var GroupWavesGame = WavesGameManager[data.EntityId];
            if (GroupWavesGame == null) {
                return;
            }
            this.WavesGameScorePropertyChanged(data, GroupWavesGame, value);
        }
    }
}
