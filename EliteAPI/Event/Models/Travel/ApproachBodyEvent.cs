using System;

using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;

using Newtonsoft.Json;

using ProtoBuf;

namespace EliteAPI.Event.Models
{

    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ApproachBodyEvent : EventBase<ApproachBodyEvent>
    {
        internal ApproachBodyEvent() { }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; private set; }

        [JsonProperty("SystemAddress")]
        public string SystemAddress { get; private set; }

        [JsonProperty("Body")]
        public string Body { get; private set; }

        [JsonProperty("BodyID")]
        public string BodyId { get; private set; }
    }

}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<ApproachBodyEvent> ApproachBodyEvent;

        internal void InvokeApproachBodyEvent(ApproachBodyEvent arg)
        {
            ApproachBodyEvent?.Invoke(this, arg);
        }
    }
}