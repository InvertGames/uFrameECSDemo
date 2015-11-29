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
    
    
    public partial class WavesGameSystem {
        
        protected override void BeginMultipleIntervalSpawn(SpawnMultipleAtInterval data, SpawnMultipleAtInterval group) {
            var handler = new BeginMultipleIntervalSpawn();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void WavesGameCreated(WavesGame data, WavesGame group) {
            var handler = new WavesGameCreated();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void PointsOnDestroyComponentDestroyed(PointsOnDestroy data, PointsOnDestroy group) {
            var handler = new PointsOnDestroyComponentDestroyed();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void WavesGameSystemGameOverHandler(uFrameECSDemo.GameOver data, WavesGame group) {
            var handler = new WavesGameSystemGameOverHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void BeginIntervalSpawn(SpawnAtInterval data, SpawnAtInterval group) {
            var handler = new BeginIntervalSpawn();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
    }
}
