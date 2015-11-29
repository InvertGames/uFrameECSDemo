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
    
    
    public partial class ScrollSystem : uFrame.ECS.ISystemUpdate {
        
        protected override void ScrollSystemUpdateHandler(BackgroundScroller group) {
            var handler = new ScrollSystemUpdateHandler();
            handler.System = this;
            handler.Group = group;
            handler.Execute();
        }
        
        public virtual void SystemUpdate() {
            ScrollSystemUpdateFilter();
        }
        
        protected override void GrabStartPosition(BackgroundScroller data, BackgroundScroller group) {
            var handler = new GrabStartPosition();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
    }
}
