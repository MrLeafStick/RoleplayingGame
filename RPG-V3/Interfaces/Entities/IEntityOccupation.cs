namespace RPG_V3.Interfaces.Entities
{
    public interface IEntityOccupation
    {
        public string Name { get; }
        public int SkillLevel { get; }
        public void LevelUp();
    }
}
