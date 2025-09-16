namespace sprint_1_activity_3.Clases
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public string StudentInfo()
        {
            return $"El nombre del estudiante es: {Name}, su edad es: {Age} años y está en el grado {Grade}.";
        }
    }
}