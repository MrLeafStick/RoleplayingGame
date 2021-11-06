using System;
using System.Collections.Generic;
using System.Text;

// Base interface for all animate entities, including living creatures,
// animals, humanoids, the undead, monsters, and magical creatures.
namespace RPG_V3.Interfaces
{
    public interface IEntity
    {
        EntityTypes Type { get; }
        public double HealthPoints { get; }
        public bool IsDead { get; }
    }

    public enum EntityTypes
    {
        Critter,
        Humanoid,
        Monster,
        UnDead,
        Spectre,
        Magical,
        Deity
    }
}
