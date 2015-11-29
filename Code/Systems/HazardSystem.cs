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
    
    
    public partial class HazardSystem {
        
        protected override void HandleDestroyOnCollisionHandler(uFrame.ECS.OnTriggerEnterDispatcher data, DestroyOnCollision source) {
            var handler = new HandleDestroyOnCollisionHandler();
            handler.System = this;
            handler.Event = data;
            handler.Source = source;
            handler.Execute();
        }
        
        protected override void BeginRandomRotation(RandomRotation data, RandomRotation group) {
            var handler = new BeginRandomRotation();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void ProjectileCreated(Projectile data, Projectile group) {
            var handler = new ProjectileCreated();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void SetRandomPosition(SpawnWithRandomX data, SpawnWithRandomX group) {
            var handler = new SetRandomPosition();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void HazardSystemOnCollisionEnterDispatcherHandler(uFrame.ECS.OnCollisionEnterDispatcher data, DestroyOnCollision source) {
        }
    }
}
