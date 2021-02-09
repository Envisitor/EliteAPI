using System;
using System.Collections.Generic;

using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;

using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class MissionCompletedEvent : EventBase
    {
        internal MissionCompletedEvent() { }

        [JsonProperty("Faction")]
        public string Faction { get; private set; }

        [JsonProperty("Name")]
        public string Name { get; private set; }

        [JsonProperty("MissionID")]
        public string MissionId { get; private set; }

        [JsonProperty("TargetType")]
        public string TargetType { get; private set; }

        [JsonProperty("TargetType_Localised")]
        public string TargetTypeLocalised { get; private set; }

        [JsonProperty("TargetFaction")]
        public string TargetFaction { get; private set; }

        [JsonProperty("NewDestinationSystem")]
        public string NewDestinationSystem { get; private set; }

        [JsonProperty("DestinationSystem")]
        public string DestinationSystem { get; private set; }

        [JsonProperty("NewDestinationStation")]
        public string NewDestinationStation { get; private set; }

        [JsonProperty("DestinationStation")]
        public string DestinationStation { get; private set; }

        [JsonProperty("Target")]
        public string Target { get; private set; }

        [JsonProperty("Reward")]
        public long Reward { get; private set; }

        [JsonProperty("FactionEffects")]
        public IReadOnlyList<FactionEffectInfo> FactionEffectInfos { get; private set; }


        public class FactionEffectInfo
        {
            internal FactionEffectInfo() { }

            [JsonProperty("Faction")]
            public string Faction { get; private set; }

            [JsonProperty("Effects")]
            public IReadOnlyList<EffectInfo> Effects { get; private set; }

            [JsonProperty("Influence")]
            public IReadOnlyList<InfluenceInfo> Influence { get; private set; }

            [JsonProperty("ReputationTrend")]
            public string ReputationTrend { get; private set; }

            [JsonProperty("Reputation")]
            public string Reputation { get; private set; }
        }

        public class EffectInfo
        {
            internal EffectInfo() { }

            [JsonProperty("Effect")] 
            public string Effect { get; private set; }

            [JsonProperty("Effect_Localised")] 
            public string EffectLocalised { get; private set; }

            [JsonProperty("Trend")]
            public string Trend { get; private set; }
        }

        public class InfluenceInfo
        {
            internal InfluenceInfo() { }

            [JsonProperty("SystemAddress")]
            public long SystemAddress { get; private set; }

            [JsonProperty("Trend")]
            public string Trend { get; private set; }

            [JsonProperty("Influence")] 
            public string Influence { get; private set; }
        }
    }

    public partial class MissionCompletedEvent
    {
        public static MissionCompletedEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<MissionCompletedEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<MissionCompletedEvent> MissionCompletedEvent;

        internal void InvokeMissionCompletedEvent(MissionCompletedEvent arg)
        {
            MissionCompletedEvent?.Invoke(this, arg);
        }
    }
}