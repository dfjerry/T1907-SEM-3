using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TravelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TravelService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TravelService.svc or TravelService.svc.cs at the Solution Explorer and start debugging.
    public class TravelService : ITravelService
    {
        TravelDataContext data = new TravelDataContext();
        public bool AddLocation(Location location)
        {
            try
            {
                data.Locations.InsertOnSubmit(location);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteLocation(string id)
        {
            try
            {
                var location = data.Locations.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Locations.DeleteOnSubmit(location);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

       

        public bool EditLocation(string id, Location newlocation)
        {
            try
            {
                var location = data.Locations.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Locations.DeleteOnSubmit(location);
                data.Locations.InsertOnSubmit(newlocation);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Location> GetLocations()
        {
            try
            {
                var locations = (from location in data.Locations select location).ToList();
                return locations;
            }
            catch
            {
                return null;
            }
        }
    }
}
