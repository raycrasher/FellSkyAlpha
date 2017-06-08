using Duality;
using Duality.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Components
{
    [Duality.Editor.EditorHintCategory("FellSky")]
    public class Vehicle: Component
    {
        private string name;

        public string Name {
            get => name;
            set => name = value;
        }
    }
}
