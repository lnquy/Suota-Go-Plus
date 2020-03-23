﻿using Prism.Events;
using suota_pgp.Model;

namespace suota_pgp
{
    public static class PrismEvents
    {
        public class CharacteristicUpdatedEvent : PubSubEvent<CharacteristicUpdate> { }

        public class GoPlusFoundEvent : PubSubEvent<GoPlus> { }

        public class PermissionStateChangedEvent : PubSubEvent<PermissionState> { }

        public class SuotaProgressUpdateEvent : PubSubEvent<SuotaProgress> { }

        public class RestoreCompleteEvent : PubSubEvent { }
    }
}