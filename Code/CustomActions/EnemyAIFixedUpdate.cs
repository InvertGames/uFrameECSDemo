using UnityEngine;

namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    
    
    public partial class EnemyAIFixedUpdate {
        
        public override void Execute() {
            float newManeuver = Mathf.MoveTowards(EnemyAI.GetComponent<Rigidbody>().velocity.x, EnemyAI.TargetManeuver, EnemyAI.Smoothing * Time.deltaTime);
            EnemyAI.GetComponent<Rigidbody>().velocity = new Vector3(newManeuver, 0.0f, EnemyAI.CurrentSpeed);
            //EnemyAI.GetComponent<Rigidbody>().position = new Vector3
            //(
            //    Mathf.Clamp(EnemyAI.GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            //    0.0f,
            //    Mathf.Clamp(EnemyAI.GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
            //);

            EnemyAI.GetComponent<Rigidbody>().rotation = Quaternion.Euler(0, 0, EnemyAI.GetComponent<Rigidbody>().velocity.x * -EnemyAI.Tilt);
        }

   
	
    }
}
