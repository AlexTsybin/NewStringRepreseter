namespace StringRepresenter.API.Model.TicketForEvents
{
    public class Hall
    {
        public string Plan { get; set; }
        public string Name { get; set; }

        public Hall(string plan, string name)
        {
            Plan = plan;
            Name = name;
        }
    }
}
