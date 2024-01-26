using Engine.BaseAssets.Components;
using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Dynamic;

namespace Quest.Content.Scripts
{
    public class TriggerTr : BehaviourComponent
    {

        public override void Start()
        {
            GameObject.GetComponent<Collider>().OnTriggerEnter += TriggerTr_OnTriggerEnter; 
            GameObject.GetComponent<Collider>().OnTriggerStay += TriggerTr_OnTriggerStay;
            GameObject.GetComponent<Collider>().OnTriggerExit += TriggerTr_OnTriggerExit;


        }
        
            private void TriggerTr_OnTriggerStay(Collider sender, Collider other)
            {
                //throw new NotImplementedException();
                
            }

            private void TriggerTr_OnTriggerEnter(Collider sender, Collider other)
            {
          
                
            if (other.GameObject.Name == "Camera")
                {
                GameObject.GetComponent<Rigidbody>()?.AddImpulse(other.GameObject.Transform.Forward * 3.0);
                } 
            }


            private void TriggerTr_OnTriggerExit(Collider sender, Collider other)
            {
                //Logger.Log(LogType.Info, "TrigExit");
            }
        
    }
}