using System;

namespace CarRace.MyClasses
{
    class Driver
    {
        public string Name { get; set; }
        public int Skill{ get; set; }

        public Driver()
        {
            Skill = SkillGenerator();
        }

        private int SkillGenerator()
        {
            int skill = new Random().Next(1, 10);

            return skill;
        }
        
    }
}
