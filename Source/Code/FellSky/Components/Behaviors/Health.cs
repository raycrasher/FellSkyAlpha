using Duality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Components.Behaviors
{
    [Duality.Editor.EditorHintCategory("Behaviors")]
    public class Health: Component
    {
        private int maxHealth, currentHealth;

        public int MaxHealth
        {
            get => maxHealth;
            set => maxHealth = value;
        }
        public int CurrentHealth
        {
            get => currentHealth;
            set => currentHealth = value;
        }

    }
}
