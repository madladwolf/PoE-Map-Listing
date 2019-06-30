namespace CSharp_WinF_CompletedMaps
{
    public class Maps
    {
        private string name { get; set; }
        private string extraMission { get; set; }
        private string layout { get; set; }

        private int tier { get; set; }

        public Maps() { }
        public Maps(string name, int tier, string extraMission, string layout)
        {
            this.name = name;
            this.tier = tier;
            this.extraMission = extraMission;
            this.layout = layout;
        }
        public Maps(Maps maps)
        {
            this.name = maps.name;
            this.tier = maps.tier;
            this.extraMission = maps.extraMission;
            this.layout = maps.layout;
        }

        public override string ToString()
        {
            return $"#### {name} ####" +
                $"\nName: {name}" +
                $"\nTier: {tier}" +
                $"\nExtra Mission Completed: {extraMission}" +
                $"\nHow good is the layout: {layout}" +
                $"\n##########################";
        }
        public string ToString2Read()
        {
            return $"{name}|{tier}|{extraMission}|{layout}";
        }
    }
}
