namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public partial class EnemyAISystemFixedUpdateHandler {
        
        public virtual void Execute() {
            float newManeuver = Mathf.MoveTowards(Group.GetComponent<Rigidbody>().velocity.x, Group.TargetManeuver, Group.Smoothing * Time.deltaTime);
            Group.GetComponent<Rigidbody>().velocity = new Vector3(newManeuver, 0.0f, Group.CurrentSpeed);
            //EnemyAI.GetComponent<Rigidbody>().position = new Vector3
            //(
            //    Mathf.Clamp(EnemyAI.GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            //    0.0f,
            //    Mathf.Clamp(EnemyAI.GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
            //);

            Group.GetComponent<Rigidbody>().rotation = Quaternion.Euler(0, 0, Group.GetComponent<Rigidbody>().velocity.x * -Group.Tilt);
        }
    }
}
