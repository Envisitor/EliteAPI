﻿using System;

using EliteAPI.Event.Models;
using EliteAPI.Event.Models.Abstractions;

using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public partial class CarrierBuyEvent : EventBase
    {
        internal CarrierBuyEvent() { }

        [JsonProperty("BoughtAtMarket")]
        public string MarketId { get; private set; }

        [JsonProperty("CarrierID")]
        public string CarrierId { get; private set; }

        [JsonProperty("Location")]
        public string StarSystem { get; private set; }

        [JsonProperty("Price")]
        public long Price { get; private set; }

        [JsonProperty("Variant")]
        public string Variant { get; private set; }

        [JsonProperty("Callsign")]
        public string Callsign { get; private set; }
    }

    public partial class CarrierBuyEvent
    {
        public static CarrierBuyEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<CarrierBuyEvent>(json);
        }
    }
}

namespace EliteAPI.Event.Handler
{
    public partial class EventHandler
    {
        public event EventHandler<CarrierBuyEvent> CarrierBuyEvent;

        internal void InvokeCarrierBuyEvent(CarrierBuyEvent arg)
        {
            CarrierBuyEvent?.Invoke(this, arg);
        }
    }
}