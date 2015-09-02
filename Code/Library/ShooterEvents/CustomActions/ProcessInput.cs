using UnityEngine;

namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    
    
    public partial class ProcessInput {
        
        public override void Execute()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
                if (MoveBackwards != null) MoveRight();
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                if (MoveBackwards != null) MoveLeft();
            if (Input.GetKeyDown(KeyCode.UpArrow))
                if (MoveBackwards != null) MoveForwards();
            if (Input.GetKeyDown(KeyCode.DownArrow))
                if (MoveBackwards != null) MoveBackwards();
        }
    }
}
