using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapGallery.Web.Models
{
    public class City : IMapEntity
    {
        public int Id { get; }
        public string Name { get; }
        public string FullName { get; }
        public State State { get; set; }
        public Continent Continent { get; set; }

        public void SetState(State state)
        {
            State = state;
        }

        public City(string name, string fullName, State state)
        {
            Name = name;
            FullName = fullName;
            State = state;
        }
    }
}