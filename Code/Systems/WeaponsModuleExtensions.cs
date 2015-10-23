// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    
    
    #region 
static
    public class WeaponsModuleExtensions {
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<GunnerInput> GunnerInputManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<GunnerInput>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<Gunner> GunnerManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Gunner>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<Gun> GunManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Gun>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<ShootingGuns> ShootingGunsManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<ShootingGuns>();
        }
        #endregion
        
        #region 
static
        public List<GunnerInput> GunnerInputComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<GunnerInput>().Components;
        }
        #endregion
        
        #region 
static
        public List<Gunner> GunnerComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Gunner>().Components;
        }
        #endregion
        
        #region 
static
        public List<Gun> GunComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<Gun>().Components;
        }
        #endregion
        
        #region 
static
        public List<ShootingGuns> ShootingGunsComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<ShootingGuns>().Components;
        }
        #endregion
    }
    #endregion
}