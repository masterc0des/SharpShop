using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8618

namespace SharpShop.Models
{
    public class User
    {
        private int id;
        private string vorname;
        private string nachname;
        private DateTime geburtsdatum;
        private string adresse;
        private int hausnummer;
        private int plz;
        private string ort;
        private string username;
        private string email;
        private string kennwort;

        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required]
        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }
        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }
        public DateTime Geburtsdatum
        {
            get { return geburtsdatum; }
            set { geburtsdatum = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public int Hausnummer
        {
            get { return hausnummer; }
            set { hausnummer = value; }
        }
        public int Plz
        {
            get { return plz; }
            set { plz = value; }
        }
        public string Ort
        {
            get { return ort; }
            set { ort = value; }
        }
        
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Kennwort
        {
            get { return kennwort; }
            set { kennwort = value; }
        }
    }
}
