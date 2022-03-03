using BorderControl.Interfaces;

namespace BorderControl.Models
{
    internal class Robot : IIdent
    {
        public Robot(string model,string id)
        {
            this.Model=model;
            this.Id=id;
        }
        public string Model { get; private set; }
        public string Id { get; private set; }
    }
}
