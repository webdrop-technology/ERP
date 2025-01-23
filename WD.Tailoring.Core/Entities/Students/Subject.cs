
namespace WD.Tailoring.Core.Entities.Students
{
    public class Subject:BaseEntity
    {

        //commerce

        //Accountancy(Mandatory)
        //Economics(Mandatory)
        //Business Studies(Mandatory)
        //English(Mandatory)
        //Informatics Practices or Mathematics(Optional)
        //Physical Education(Optional)

        //Science
        //Physics Chemistry Maths English Hindi
        //Physics Chemistry Biology English Hindi

        //English, Economics, History, Geography, Sociology and Psychology
        public string? Name { get; set; }
        public int SectionId { get; set; }
        public virtual Section? Section { get; set; }
    }
}
