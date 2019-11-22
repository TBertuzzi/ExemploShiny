using System;
using System.Threading.Tasks;
using Shiny.Locations;

namespace ExemploShiny.Delegates
{
    public class LocationDelegates : IGeofenceDelegate, IGpsDelegate
    {
        public Task OnReading(IGpsReading reading)
        {
            //Aqui voce Pode Implementar um Delagate para o GPS
            return null;
        }

        public async Task OnStatusChanged(GeofenceState newStatus, GeofenceRegion region)
        {
            //Aqui voce Pode implementar um Delegate pra Geofence
        }


    }
}
