using System;

using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;

using Newtonsoft.Json;

using ProtoBuf;

namespace EliteAPI.Event.Models
{

    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ScanOrganicEvent : EventBase<ScanOrganicEvent>
    {
        internal ScanOrganicEvent() { }

        [JsonProperty("ScanType")]
        public string ScanType { get; private set; }

        [JsonProperty("Genus")]
        public string Genus { get; private set; }

        [JsonProperty("Genus_Localised")]
        public string Genus_Localised { get; private set; }

        [JsonProperty("Species")]
        public string Species { get; private set; }

        [JsonProperty("Species_Localised")]
        public string Species_Localised { get; private set; }

        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; private set; }

        [JsonProperty("Body")]
        public int Body { get; private set; }
    }

}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<ScanOrganicEvent> ScanOrganicEvent;

        internal void InvokeScanOrganicEvent(ScanOrganicEvent arg)
        {
            ScanOrganicEvent?.Invoke(this, arg);
        }
    }
}