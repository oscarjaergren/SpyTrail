using System;
using System.Collections.Generic;
using System.Text;

namespace SpyTrail.Models
{
    public class User
    {
        public string Name { get; set; }

        public Guid Id { get; set; } = Guid.NewGuid();
    }
}