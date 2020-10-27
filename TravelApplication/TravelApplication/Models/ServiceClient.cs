using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelApplication.TravelServiceReferences;

namespace TravelApplication.Models
{
    public class ServiceClient
    {
        TravelServiceClient client = new TravelServiceClient();

        public List<Location> getAllLocation()
        {
            var list = client.GetLocations().ToList();
            var rt = new List<Location>();
            list.ForEach(b => rt.Add(new Location()
            {
                id = b.id,
                LocationAddress = b.LocationAddress,
                LocationDescription = b.LocationDescription,
                LocationName = b.LocationName,
                Status = b.Status,
            }));
            return rt;
        }

        public bool AddLocation(Location newlocation)
        {
            var location = new TravelServiceReferences.Location()
            {
                id = newlocation.id,
                LocationAddress = newlocation.LocationAddress,
                LocationDescription = newlocation.LocationDescription,
                LocationName = newlocation.LocationName,
                Status = newlocation.Status,
            };
            return client.AddLocation(location);
          
        }

        public bool EditLocation(Location newlocation)
        {
            var location = new TravelServiceReferences.Location()
            {
                id = newlocation.id,
                LocationAddress = newlocation.LocationAddress,
                LocationDescription = newlocation.LocationDescription,
                LocationName = newlocation.LocationName,
                Status = newlocation.Status,
            };
            return client.EditLocation(location.id.ToString(), location);
        }

        public bool DeleteLocation(string id)
        {
            return client.DeleteLocation(id);
        }
    }
}