namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public partial class EnemyAICreated {

        public void Execute()
        {
            Group.CurrentSpeed = Group.GetComponent<Rigidbody>().velocity.z;
            System.StartCoroutine(Evade());
        }


        IEnumerator Evade()
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(Group.StartWait.x, Group.StartWait.y));
            while (true)
            {
                if (Group == null || UnityEngine.Object.ReferenceEquals(Group, null))
                {
                    yield break;
                }
                Group.TargetManeuver = UnityEngine.Random.Range(1, Group.Dodge) * -Mathf.Sign(Group.transform.position.x);
                yield return new WaitForSeconds(UnityEngine.Random.Range(Group.ManeuverTime.x, Group.ManeuverTime.y));
                Group.TargetManeuver = 0;
                yield return new WaitForSeconds(UnityEngine.Random.Range(Group.ManeuverWait.x, Group.ManeuverWait.y));
            }
        }
    }
}
