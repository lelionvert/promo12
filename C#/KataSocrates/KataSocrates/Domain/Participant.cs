namespace KataSocrates.Domain
{
    public class Participant
    {
        public Diet Diet { get; set; }

        public string Name { get; }

        public Participant(string name)
        {
            this.Name = name;
        }
    }
}
