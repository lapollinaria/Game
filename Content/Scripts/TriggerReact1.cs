using Engine.BaseAssets.Components;
using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Content.Scripts
{
    public class TriggerReact1 : BehaviourComponent
    {
        public override void Start()
        {
            GameObject.GetComponent<Collider>().OnCollisionBegin += TriggerReact1_OnCollisionBegin;
            GameObject.GetComponent<Collider>().OnCollision += TriggerReact1_OnCollision;
            GameObject.GetComponent<Collider>().OnCollisionEnd += TriggerReact1_OnCollisionEnd;
        }

        private void TriggerReact1_OnCollisionEnd(Collider sender, Collider other)
        {
            //Logger.Log(LogType.Info, "ColEnd");
            
        }

        private void TriggerReact1_OnCollision(Collider sender, Collider other)
        {
            //throw new NotImplementedException();
        }

        private void TriggerReact1_OnCollisionBegin(Collider sender, Collider other)
        {
            Logger.Log(LogType.Info, "ColStart");
            GameObject.GetComponent<Rigidbody>().AddImpulse(new LinearAlgebra.Vector3(2.0, 2.0, 2.0));
        }
    }
}
