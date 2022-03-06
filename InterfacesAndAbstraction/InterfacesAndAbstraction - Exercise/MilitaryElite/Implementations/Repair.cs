using MilitaryElite.Interfaces;

namespace MilitaryElite.Implementations
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hourWorked)
        {
            PartName = partName;
            HourWorked = hourWorked;
        }
        public string PartName { get; set; }
        public int HourWorked { get; set; }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {HourWorked}";
        }
    }
}
