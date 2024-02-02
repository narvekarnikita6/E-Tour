// Repository/IItineraryMasterRepository.cs

using System.Collections.Generic;
using ETourProject1.Models;

namespace ETourProject1.Repository
{
    public interface Itinerary_MasterInterface
    {
        IEnumerable<Itinerary_Master> GetAll();
        Itinerary_Master GetById(int id);
        void Add(Itinerary_Master itinerary);

    }
}
