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
    
    
    public partial class PlayerSystem {
        
        protected override void PlayerGunnerCreated(PlayerGunner data, PlayerGunner group) {
            var handler = new PlayerGunnerCreated();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void PlayerSystemGameOverHandler(uFrameECSDemo.GameOver data, WavesGame group) {
            var handler = new PlayerSystemGameOverHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void PlayerGunnerComponentDestroyed(PlayerGunner data, PlayerGunner group) {
            var handler = new PlayerGunnerComponentDestroyed();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void PlayerSystemOnCollisionEnterHandler(uFrame.ECS.OnTriggerEnterDispatcher data, Hazard collider, PlayerGunner source) {
            var handler = new PlayerSystemOnCollisionEnterHandler();
            handler.System = this;
            handler.Event = data;
            handler.Collider = collider;
            handler.Source = source;
            handler.Execute();
        }
    }
}
