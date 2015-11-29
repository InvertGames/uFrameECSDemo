namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using uFrameECSDemo;
    using UniRx;
    using UnityEngine;
    
    
    public partial class WeaponInputSystem : uFrame.ECS.ISystemUpdate {
        
        protected override void GunnerInputUpdateHandler(PlayerGunner group) {
            var handler = new GunnerInputUpdateHandler();
            handler.System = this;
            handler.Group = group;
            handler.Execute();
        }
        
        public virtual void SystemUpdate() {
            GunnerInputUpdateFilter();
        }
    }
}
