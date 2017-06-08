using Duality;
using Duality.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Components
{
    [Duality.Editor.EditorHintCategory("FellSky")]
    public class Ship: Component
    {
        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
