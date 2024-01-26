using Engine.BaseAssets.Components;
using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Content.Scripts
{
    public class TargetGreen : BehaviourComponent
    {
        double t = 0.0;
        bool placed = false;
        bool once = true;
        public override void Start()
        {
            GameObject.GetComponent<Collider>().OnTriggerEnter += TriggerTr_OnTriggerEnter;
            GameObject.GetComponent<Collider>().OnTriggerStay += TriggerTr_OnTriggerStay;


        }

        private void TriggerTr_OnTriggerStay(Collider sender, Collider other)
        {
            if (other.GameObject.Name == "Interaction")
            {
                t += Time.DeltaTime;
                if (t >= 1)
                {
                    if (placed & once)
                    {
                        other.GameObject.GetComponent<Interaction>().Increment();
                        placed = false;
                        once = false;
                    }
                    t = 0.0;
                }


            }
        }

        private void TriggerTr_OnTriggerEnter(Collider sender, Collider other)
        {

            if (other.GameObject.Name == "GreenCube")
            {
                Logger.Log(LogType.Info, "Yay!");
                placed = true;
                Logger.Log(LogType.Info, placed.ToString());

            }
        }


    }
}
