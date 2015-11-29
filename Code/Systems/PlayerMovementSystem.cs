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
    
    
    public partial class PlayerMovementSystem : uFrame.ECS.ISystemFixedUpdate {
        
        protected override void ShooterFixedUpdateHandler(Movable group) {
            var handler = new ShooterFixedUpdateHandler();
            handler.System = this;
            handler.Group = group;
            handler.Execute();
        }
        
        public virtual void SystemFixedUpdate() {
            ShooterFixedUpdateFilter();
        }
    }
}
