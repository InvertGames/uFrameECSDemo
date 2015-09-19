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
    
    
    [uFrame.Attributes.uFrameIdentifier("c33125c8-912c-4fa4-921b-3b89581f3b04")]
    public partial class PlayerSystem : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<Movable> _MovableManager;
        
        private IEcsComponentManagerOf<Hazard> _HazardManager;
        
        private IEcsComponentManagerOf<PlayerGunner> _PlayerGunnerManager;
        
        private PlayerGunnerCreatedComponentCreated PlayerGunnerCreatedComponentCreatedInstance = new PlayerGunnerCreatedComponentCreated();
        
        private PlayerGunnerComponentDestroyed PlayerGunnerComponentDestroyedInstance = new PlayerGunnerComponentDestroyed();
        
        private PlayerSystemOnCollisionEnterHandler PlayerSystemOnCollisionEnterHandlerInstance = new PlayerSystemOnCollisionEnterHandler();
        
        public IEcsComponentManagerOf<Movable> MovableManager {
            get {
                return _MovableManager;
            }
            set {
                _MovableManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Hazard> HazardManager {
            get {
                return _HazardManager;
            }
            set {
                _HazardManager = value;
            }
        }
        
        public IEcsComponentManagerOf<PlayerGunner> PlayerGunnerManager {
            get {
                return _PlayerGunnerManager;
            }
            set {
                _PlayerGunnerManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            PlayerGunnerManager = ComponentSystem.RegisterGroup<PlayerGunnerGroup,PlayerGunner>();
            MovableManager = ComponentSystem.RegisterComponent<Movable>();
            HazardManager = ComponentSystem.RegisterComponent<Hazard>();
            PlayerGunnerManager.CreatedObservable.Subscribe(PlayerGunnerCreatedComponentCreatedFilter).DisposeWith(this);
            PlayerGunnerManager.RemovedObservable.Subscribe(_=>PlayerGunnerComponentDestroyed(_,_)).DisposeWith(this);
            this.OnEvent<uFrame.ECS.OnTriggerEnterDispatcher>().Subscribe(_=>{ PlayerSystemOnCollisionEnterFilter(_); }).DisposeWith(this);
        }
        
        protected void PlayerGunnerCreatedComponentCreated(PlayerGunner data, PlayerGunner group) {
            var handler = PlayerGunnerCreatedComponentCreatedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void PlayerGunnerCreatedComponentCreatedFilter(PlayerGunner data) {
            var GroupItem = PlayerGunnerManager[data.EntityId];
            if (GroupItem == null) {
                return;
            }
            this.PlayerGunnerCreatedComponentCreated(data, GroupItem);
        }
        
        protected void PlayerGunnerComponentDestroyed(PlayerGunner data, PlayerGunner group) {
            var handler = PlayerGunnerComponentDestroyedInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void PlayerGunnerComponentDestroyedFilter(PlayerGunner data) {
            var GroupItem = PlayerGunnerManager[data.EntityId];
            if (GroupItem == null) {
                return;
            }
            this.PlayerGunnerComponentDestroyed(data, GroupItem);
        }
        
        protected void PlayerSystemOnCollisionEnterHandler(uFrame.ECS.OnTriggerEnterDispatcher data, Hazard collider, PlayerGunner source) {
            var handler = PlayerSystemOnCollisionEnterHandlerInstance;;
            handler.System = this;
            handler.Event = data;
            handler.Collider = collider;
            handler.Source = source;
            StartCoroutine(handler.Execute());
        }
        
        protected void PlayerSystemOnCollisionEnterFilter(uFrame.ECS.OnTriggerEnterDispatcher data) {
            var ColliderHazard = HazardManager[data.ColliderId];
            if (ColliderHazard == null) {
                return;
            }
            var SourceItem = PlayerGunnerManager[data.EntityId];
            if (SourceItem == null) {
                return;
            }
            this.PlayerSystemOnCollisionEnterHandler(data, ColliderHazard, SourceItem);
        }
    }
}
