﻿using System;

using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;

using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class KickedFromSquadronEvent : EventBase
    {
        internal KickedFromSquadronEvent() { }

        [JsonProperty("SquadronName")]
        public string Name { get; private set; }
    }

    public partial class KickedFromSquadronEvent
    {
        public static KickedFromSquadronEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<KickedFromSquadronEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<KickedFromSquadronEvent> KickedFromSquadronEvent;

        internal void InvokeKickedFromSquadronEvent(KickedFromSquadronEvent arg)
        {
            KickedFromSquadronEvent?.Invoke(this, arg);
        }
    }
}