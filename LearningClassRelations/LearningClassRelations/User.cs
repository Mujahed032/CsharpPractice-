using System.Numerics;

namespace LearningClassRelations
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Phone> phones { get; set; }
    }
}
