using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroApi2.Entities

{
    public class SuperHero //SuperHero vai herdar as propriedades do "person" 
    {
    
        public int Id { get; set; }
     
        public string Name { get; set; }

        public string FirstName { get; set; } = string.Empty; // Quando coloca o string.Empty significa que o campo string será vazio, sem a necessidade de atribuir um valor a ela
   
        public string LastName { get; set; } = string.Empty;

        public string Place {  get; set; } = string.Empty;
    }
}
