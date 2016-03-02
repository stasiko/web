using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapGallery.Web.Models
{

    public class Country : IMapEntity
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

        public Country(string name, string fullName, State state)
        {
            Name = name;
            FullName = fullName;
            State = state;
        }
    }
}