﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomizerMod.RandomizerData
{
    public class TransitionDef
    {
        [Newtonsoft.Json.JsonIgnore]
        public string Name => $"{SceneName}[{DoorName}]";

        public string SceneName { get; init; }
        public string DoorName { get; init; }
        public string AreaName { get; init; }
        public string VanillaTarget { get; init; }
        public TransitionDirection Direction { get; init; }

        public bool IsAreaTransition { get; init; }
        public bool Isolated { get; init; }
        public bool DeadEnd { get; init; }
        public TransitionSides Sides { get; init; }
    }

    public enum TransitionSides
    {
        Both = 0,
        /// <summary>
        /// A one way transition exiting a scene.
        /// </summary>
        OneWayIn = 1,
        /// <summary>
        /// A one way transition entering a scene.
        /// </summary>
        OneWayOut = 2,
    }

    public enum TransitionDirection
    {
        Door,
        Left,
        Right,
        Top,
        Bot,
    }

}
