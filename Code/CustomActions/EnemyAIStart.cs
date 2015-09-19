using UnityEngine;

namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    
    
    public partial class EnemyAIStart {
        
        public override void Execute()
        {
            EnemyAI.CurrentSpeed = EnemyAI.GetComponent<Rigidbody>().velocity.z;
            System.StartCoroutine(Evade());
        }

 
        IEnumerator Evade()
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(EnemyAI.StartWait.x, EnemyAI.StartWait.y));
            while (true)
            {
                EnemyAI.TargetManeuver = UnityEngine.Random.Range(1, EnemyAI.Dodge) * -Mathf.Sign(EnemyAI.transform.position.x);
                yield return new WaitForSeconds(UnityEngine.Random.Range(EnemyAI.ManeuverTime.x, EnemyAI.ManeuverTime.y));
                EnemyAI.TargetManeuver = 0;
                yield return new WaitForSeconds(UnityEngine.Random.Range(EnemyAI.ManeuverWait.x, EnemyAI.ManeuverWait.y));
            }
        }
    }
}
