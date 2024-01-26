using Engine.BaseAssets.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Content.Scripts
{
    public class PhysMat : BehaviourComponent
    {
        public override void Start()
        {
            GameObject.GetComponent<Rigidbody>().Material = new PhysicalMaterial(0.1, 0.0, CombineMode.Minimum, CombineMode.Minimum);
        }
    }
}
