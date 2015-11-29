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
    
    
    public partial class UISystem {
        
        protected override void SetScoreLabel(WavesGame data, WavesGame group, PropertyChangedEvent<System.Int32> value) {
            var handler = new SetScoreLabel();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.OldValue = value.PreviousValue;
            handler.NewValue = value.CurrentValue;
            handler.Execute();
        }
        
        protected override void WavesGameComponentDestroyed(WavesGame data, WavesGame group) {
            var handler = new WavesGameComponentDestroyed();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected override void UISystemPointerClickDispatcherHandler(uFrame.ECS.PointerClickDispatcher data, PlayGameButton source) {
            var handler = new UISystemPointerClickDispatcherHandler();
            handler.System = this;
            handler.Event = data;
            handler.Source = source;
            handler.Execute();
        }
        
        protected override void DisableUI(WavesGame data, WavesGame group) {
            var handler = new DisableUI();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
    }
}
