using Duality;
using Duality.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Components.Behaviors
{
    [Duality.Editor.EditorHintCategory("Behaviors")]
    [RequiredComponent(typeof(Health))]
    public class SpawnOnDeath: Component
    {
        private ContentRef<Prefab>[] prefabs;

        public ContentRef<Prefab>[] Prefabs {
            get => prefabs;
            set => prefabs = value;
        }
    }
}
