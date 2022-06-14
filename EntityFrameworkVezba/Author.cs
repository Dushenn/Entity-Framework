using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkVezba
{
    public enum Gender
    {
        MALE,
        FEMALE
    }
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Born { get; set; }
        public DateTime? Died { get; set; }

        public virtual List<Book> Books { get; set; }

        public Author() { }

        public Author (string name, Gender gender, DateTime born, DateTime? died)
        {
            Name = name;
            Gender = gender;
            Born = born;
            Died = died;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nGender: {Gender}\nBorn: {Born}\nDied: {(Died == null ? "still alive" : Died.ToString())}";
        }
    }
}
