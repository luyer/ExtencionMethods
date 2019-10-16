namespace ExtencionMethods
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Color HairColor { get; set; }

        public Color EyeColor { get; set; }

        public enum Color { Negro, Cafe, Azul, Verde }

        public int Height { get; set; }
    }
}