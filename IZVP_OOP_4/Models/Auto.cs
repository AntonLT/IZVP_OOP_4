namespace IZVP_OOP_4.Models
{
    public class Auto
    {
        private string ownerFirstName;
        private string ownerLastName;
        private string registrationCode;
        private string model;
        private string color;

        public Auto()
        {
        }

        public Auto(string ownerFirstName, string ownerLastName, string registrationCode, string model, string color)
        {
            this.ownerFirstName = ownerFirstName;
            this.ownerLastName = ownerLastName;
            this.registrationCode = registrationCode;
            this.model = model;
            this.color = color;
        }
    }
}