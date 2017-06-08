using Duality;
using FellSky.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Components.Behaviors
{
    [Duality.Editor.EditorHintCategory("Behaviors")]
    public class StorageTank: Component
    {
        private Store[] store;

        public Store[] Stores
        {
            get => store;
            set => store = value;
        }

        public struct Store
        {            
            private int current, max;
            private ContentRef<SubstanceType> substance;

            public int Current
            {
                get => current;
                set => current = value;
            }

            public int Max
            {
                get => max;
                set => max = value;
            }

            public ContentRef<SubstanceType> Substance
            {
                get => substance;
                set => substance = value;
            }
        }        
    }
}
