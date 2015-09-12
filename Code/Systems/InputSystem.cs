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
    
    
    public partial class InputSystem : uFrame.ECS.EcsSystem, uFrame.ECS.ISystemUpdate {
        
        private IEcsComponentManagerOf<LocalGunner> _LocalGunnerManager;
        
        public IEcsComponentManagerOf<LocalGunner> LocalGunnerManager {
            get {
                return _LocalGunnerManager;
            }
            set {
                _LocalGunnerManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            LocalGunnerManager = ComponentSystem.RegisterGroup<LocalGunnerGroup,LocalGunner>();
        }
        
        protected void GunnerInputUpdateHandler(LocalGunner group) {
            var handler = new GunnerInputUpdateHandler();
            handler.System = this;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void GunnerInputUpdateFilter() {
            var LocalGunnerItems = LocalGunnerManager.Components.GetEnumerator();
            for (
            ; LocalGunnerItems.MoveNext(); 
            ) {
                this.GunnerInputUpdateHandler(LocalGunnerItems.Current);
            }
        }
        
        public virtual void SystemUpdate() {
            GunnerInputUpdateFilter();
        }
    }
}
