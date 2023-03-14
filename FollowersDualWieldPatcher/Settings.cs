using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowersDualWieldPatcher
{

    public class Settings
    {
        // sort by armour weight
        [SettingName("Followers Dual Wield")]
        [Tooltip("Sets the Equipment Type to EitherHand for all weapons with a RightHand type")]
        public bool AllWeaponsDualWield = true;

    }
}