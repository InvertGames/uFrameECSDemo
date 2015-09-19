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
    using UniRx;
    using uFrame.ECS;
    using uFrame.Kernel;
    
    
    [uFrame.Attributes.uFrameIdentifier("b60e9496-5928-483d-b9ee-4e5ae99f0445")]
    public partial class UISystem : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<SpawnAtInterval> _SpawnAtIntervalManager;
        
        private IEcsComponentManagerOf<WavesGame> _WavesGameManager;
        
        private IEcsComponentManagerOf<SpawnMultipleAtInterval> _SpawnMultipleAtIntervalManager;
        
        private IEcsComponentManagerOf<PointsOnDestroy> _PointsOnDestroyManager;
        
        private IEcsComponentManagerOf<PlayGameButton> _PlayGameButtonManager;
        
        private WavesGameScorePropertyChanged WavesGameScorePropertyChangedInstance = new WavesGameScorePropertyChanged();
        
        private WavesGameComponentDestroyed WavesGameComponentDestroyedInstance = new WavesGameComponentDestroyed();
        
        private UISystemPointerClickDispatcherHandler UISystemPointerClickDispatcherHandlerInstance = new UISystemPointerClickDispatcherHandler();
        
        private DisableUIComponentCreated DisableUIComponentCreatedInstance = new DisableUIComponentCreated();
        
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
        
        public IEcsComponentManagerOf<PlayGameButton> PlayGameButtonManager {
            get {
                return _PlayGameButtonManager;
            }
            set {
                _PlayGameButtonManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            SpawnAtIntervalManager = ComponentSystem.RegisterComponent<SpawnAtInterval>();
            WavesGameManager = ComponentSystem.RegisterComponent<WavesGame>();
            SpawnMultipleAtIntervalManager = ComponentSystem.RegisterComponent<SpawnMultipleAtInterval>();
            PointsOnDestroyManager = ComponentSystem.RegisterComponent<PointsOnDestroy>();
            PlayGameButtonManager = ComponentSystem.RegisterComponent<PlayGameButton>();
            this.PropertyChanged<WavesGame,Int32>(Group=>Group.ScoreObservable, WavesGameScorePropertyChangedFilter, Group=>Group.Score);
            WavesGameManager.RemovedObservable.Subscribe(_=>WavesGameComponentDestroyed(_,_)).DisposeWith(this);
            this.OnEvent<uFrame.ECS.PointerClickDispatcher>().Subscribe(_=>{ UISystemPointerClickDispatcherFilter(_); }).DisposeWith(this);
            WavesGameManager.CreatedObservable.Subscribe(DisableUIComponentCreatedFilter).DisposeWith(this);
        }
        
        protected void WavesGameScorePropertyChanged(WavesGame data, WavesGame group, Int32 value) {
            var handler = WavesGameScorePropertyChangedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void WavesGameScorePropertyChangedFilter(WavesGame data, Int32 value) {
            var GroupWavesGame = WavesGameManager[data.EntityId];
            if (GroupWavesGame == null) {
                return;
            }
            this.WavesGameScorePropertyChanged(data, GroupWavesGame, value);
        }
        
        protected void WavesGameComponentDestroyed(WavesGame data, WavesGame group) {
            var handler = WavesGameComponentDestroyedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void WavesGameComponentDestroyedFilter(WavesGame data) {
            var GroupWavesGame = WavesGameManager[data.EntityId];
            if (GroupWavesGame == null) {
                return;
            }
            this.WavesGameComponentDestroyed(data, GroupWavesGame);
        }
        
        protected void UISystemPointerClickDispatcherHandler(uFrame.ECS.PointerClickDispatcher data, PlayGameButton source) {
            var handler = UISystemPointerClickDispatcherHandlerInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Source = source;
            StartCoroutine(handler.Execute());
        }
        
        protected void UISystemPointerClickDispatcherFilter(uFrame.ECS.PointerClickDispatcher data) {
            var SourcePlayGameButton = PlayGameButtonManager[data.EntityId];
            if (SourcePlayGameButton == null) {
                return;
            }
            this.UISystemPointerClickDispatcherHandler(data, SourcePlayGameButton);
        }
        
        protected void DisableUIComponentCreated(WavesGame data, WavesGame group) {
            var handler = DisableUIComponentCreatedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void DisableUIComponentCreatedFilter(WavesGame data) {
            var GroupWavesGame = WavesGameManager[data.EntityId];
            if (GroupWavesGame == null) {
                return;
            }
            this.DisableUIComponentCreated(data, GroupWavesGame);
        }
    }
}
