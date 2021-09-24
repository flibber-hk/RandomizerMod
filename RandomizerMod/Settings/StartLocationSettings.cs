﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RandomizerMod.RandomizerData;

namespace RandomizerMod.Settings
{
    [Serializable]
    public class StartLocationSettings : SettingsModule
    {
        public enum RandomizeStartLocationType : byte
        {
            Fixed,
            RandomExcludingKP,
            Random,
        }

        public RandomizeStartLocationType StartLocationType;

        public string StartLocation;

        public override void Clamp(GenerationSettings gs)
        {
            base.Clamp(gs);
            if (StartLocationType == RandomizeStartLocationType.Fixed && Data.GetStartDef(StartLocation) == null)
            {
                LogHelper.LogWarn("Found invalid fixed start location during Clamp.");
                StartLocation = Data.GetStartNames().First();
            }
        }

        public void SetStartLocation(string start) => StartLocation = start;
    }
}
