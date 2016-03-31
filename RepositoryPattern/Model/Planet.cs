using RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Model
{
    public class Planet:Entity
    {
        public string Name;
        public bool IsTerraform;

        public Planet()
        {
        }

        public Planet(int planetId, string name, bool isTerraform)
        {
            this.Id = planetId;
            this.Name = name;
            this.IsTerraform = isTerraform;
        }
    }
}
