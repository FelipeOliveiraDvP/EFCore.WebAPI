﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecretIdentity Identity { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<HeroBattle> HerosBattles { get; set; }
    }
}
