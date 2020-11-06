namespace MethodOverridingDemo
{
    public class PersonModel
    {
        public string fName { get; set; }

        public string lName { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return $"{fName} {lName}";
        }
    }
}
