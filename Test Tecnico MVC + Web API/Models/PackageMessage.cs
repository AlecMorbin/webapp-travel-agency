namespace Test_Tecnico_MVC___Web_API.Models
{
    public class PackageMessage
    {
        public Package Package { get; set; } 
        public List<MessageOb> Messages { get; set; }

        public PackageMessage(Package package, List<MessageOb> messages)
        {
            Package = package;
            Messages = messages;
        }

        public PackageMessage() { }
    }
}
