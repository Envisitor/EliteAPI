﻿using Newtonsoft.Json;

namespace EliteAPI.Event.Models.Startup
{
    /// <summary>
    /// This event is written when the commander chooses to clear their save.
    /// </summary>
    public class ClearSavedGameEvent : EventBase
    {
        internal ClearSavedGameEvent() { }

        /// <summary>
        /// The commander's name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; internal set; }

        /// <summary>
        /// The commander's Frontier ID.
        /// </summary>
        [JsonProperty("FID")]
        public string FID { get; internal set; }

        
    }
}
