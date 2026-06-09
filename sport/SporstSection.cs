using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sport
{
    public class SporstSection
    {
        public string SectionName { get; set; }
        public string CoachName { get; set; }
        public int MaxCountParticipants { get; set; }

        public List<Participant> Participants { get; set; } = new List<Participant>();

        public SporstSection(string coach, string sectionName, int maxCountParticipants) 
        {
            CoachName = coach;
            SectionName = sectionName;
            MaxCountParticipants = maxCountParticipants;
        }
    }
}
