﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using UnityEngine;

namespace CombatExtended
{
    public class CompProperties_AmmoUser : CompProperties
    {
        public int magazineSize = 0;
        public int reloadTicks = 300;
        public bool throwMote = true;
        public AmmoSetDef ammoSet = null;
        public bool spawnUnloaded = false;

        public CompProperties_AmmoUser()
        {
            compClass = typeof(CompAmmoUser);
        }
    }
}
