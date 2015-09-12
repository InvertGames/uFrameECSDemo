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
    
    
    public partial class EnemyShipGroup : ReactiveGroup<EnemyShip> {
        
        private IEcsComponentManagerOf<Deadly> _DeadlyManager;
        
        private IEcsComponentManagerOf<Ship> _ShipManager;
        
        private int lastEntityId;
        
        private Deadly Deadly;
        
        private Ship Ship;
        
        public IEcsComponentManagerOf<Deadly> DeadlyManager {
            get {
                return _DeadlyManager;
            }
            set {
                _DeadlyManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Ship> ShipManager {
            get {
                return _ShipManager;
            }
            set {
                _ShipManager = value;
            }
        }
        
        public override System.Collections.Generic.IEnumerable<UniRx.IObservable<int>> Install(uFrame.ECS.IComponentSystem componentSystem) {
            DeadlyManager = componentSystem.RegisterComponent<Deadly>();
            yield return DeadlyManager.CreatedObservable.Select(_=>_.EntityId);;
            yield return DeadlyManager.RemovedObservable.Select(_=>_.EntityId);;
            ShipManager = componentSystem.RegisterComponent<Ship>();
            yield return ShipManager.CreatedObservable.Select(_=>_.EntityId);;
            yield return ShipManager.RemovedObservable.Select(_=>_.EntityId);;
        }
        
        public override bool Match(int entityId) {
            lastEntityId = entityId;
            if ((Deadly = DeadlyManager[entityId]) == null) {
                return false;
            }
            if ((Ship = ShipManager[entityId]) == null) {
                return false;
            }
            return true;
        }
        
        public override EnemyShip Select() {
            var item = new EnemyShip();;
            item.EntityId = lastEntityId;
            item.Deadly = Deadly;
            item.Ship = Ship;
            return item;
        }
    }
}