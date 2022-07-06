// See https://aka.ms/new-console-template for more information
namespace Animal_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //AnimalQuiz animal1 = new AnimalQuiz();
            //animal1.Name = "Lion";
            //animal1.Nutrition = "Mode of nutrition is carnivores";
            //animal1.Habitat = "Lives on land(Terestrial habitat)";
            //animal1.Reproduction = "viviparous";
            //animal1.Gestation = "Gestation period is 110days";
            //animal1.Respiration = true;

            //AnimalQuiz animal2 = new AnimalQuiz();
            //animal2.Name = "Chicken";
            //animal2.Nutrition = "Mode of nutrition is omnivores";
            //animal2.Habitat = "Lives on land(Terestrial habitat)";
            //animal2.Reproduction = "oviparous";
            //animal2.Gestation = "Gestation period is 20-21 days";
            //animal2.Respiration = true;

            //AnimalQuiz animal3 = new AnimalQuiz();
            //animal3.Name = "Goat";
            //animal3.Nutrition = "Mode of nutrition is herbivores";
            //animal3.Habitat = "Lives on land(Terestrial habitat)";
            //animal3.Reproduction = "viviparous";
            //animal3.Gestation = "Gestation period is 150 days";
            //animal3.Respiration = true;

            //AnimalQuiz animal4 = new AnimalQuiz();
            //animal4.Name = "Pig";
            //animal4.Nutrition = "Mode of nutrition is omnivores";
            //animal4.Habitat = "Lives on land(Terestrial habitat)";
            //animal4.Reproduction = "viviparous";
            //animal4.Gestation = "Gestation period is 115 days";
            //animal4.Respiration = true;

            //AnimalQuiz animal5 = new AnimalQuiz();
            //animal5.Name = "Dog";
            //animal5.Nutrition = "Mode of nutrition is carnivores";
            //animal5.Habitat = "Lives on land(Terestrial habitat)";
            //animal5.Reproduction = "viviparous";
            //animal5.Gestation = "Gestation period is 58-68 days";
            //animal5.Respiration = true;


            //AnimalQuiz animal6 = new AnimalQuiz("Horse", "Mode of nutrition is herbivores", "Lives on land", "viviparous", "Gestation period is 11-12 months " ,true);

            //List<object> allanimals = new List<object>();
            //allanimals.Add(animal1.Name);
            //allanimals.Add(animal1.Nutrition);
            //allanimals.Add(animal1.Habitat);
            //allanimals.Add(animal1.Reproduction);
            //allanimals.Add(animal1.Gestation);
            //allanimals.Add(animal1.Respiration);

            //allanimals.Add(animal2.Name);
            //allanimals.Add(animal2.Nutrition);
            //allanimals.Add(animal2.Habitat);
            //allanimals.Add(animal2.Reproduction);
            //allanimals.Add(animal2.Gestation);
            //allanimals.Add(animal2.Respiration);

            //allanimals.Add(animal3.Name);
            //allanimals.Add(animal3.Nutrition);
            //allanimals.Add(animal3.Habitat);
            //allanimals.Add(animal3.Reproduction);
            //allanimals.Add(animal3.Gestation);
            //allanimals.Add(animal3.Respiration);

            //allanimals.Add(animal4.Name);
            //allanimals.Add(animal4.Nutrition);
            //allanimals.Add(animal4.Habitat);
            //allanimals.Add(animal4.Reproduction);
            //allanimals.Add(animal4.Gestation);
            //allanimals.Add(animal4.Respiration);

            //allanimals.Add(animal5.Name);
            //allanimals.Add(animal5.Nutrition);
            //allanimals.Add(animal5.Habitat);
            //allanimals.Add(animal5.Reproduction);
            //allanimals.Add(animal5.Gestation);
            //allanimals.Add(animal5.Respiration);

            //allanimals.Add(animal6.Name);
            //allanimals.Add(animal6.Nutrition);
            //allanimals.Add(animal6.Habitat);
            //allanimals.Add(animal6.Reproduction);
            //allanimals.Add(animal6.Gestation);
            //allanimals.Add(animal6.Respiration);


            //foreach (var animal in allanimals)
            //{
            //    Console.WriteLine(animal);
            //}

            List<AnimalQuiz> Listquestions = new List<AnimalQuiz>()
            {
                new AnimalQuiz("Lion", "Mode of nutrition is carnivores", "Lives on land(Terestial habitat)", "viviparous", "Gestation period is 110days " ,true),
                new AnimalQuiz("Chicken", "Mode of nutrition is omnivores", "Lives on land(Terestial habitat)", "oviviparous", "Gestation period is 20-21 days" ,true),
                new AnimalQuiz("Goat","Mode of nutrition is herbivores", "Lives on land(Terestial habitat)", "viviparous", "Gestation period is 150 days", true),
                new AnimalQuiz("Pig","Mode of nutrition is omnivores", "Lives on land(Terestial habitat)", "viviparous", "Gestation period is 115 days", true),
                new AnimalQuiz("Dog","Mode of nutrition is carnivores", "Lives on land(Terestial habitat)", "viviparous", "Gestation period is 58-68 days", true),
                new AnimalQuiz("Horse","Mode of nutrition is herbivores", "Lives on land(Terestial habitat)", "viviparous", "Gestation period is 11-12 months", true),

            };
            foreach (var animal in Listquestions) 
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Nutrition);
                Console.WriteLine(animal.Habitat);
                Console.WriteLine(animal.Reproduction);
                Console.WriteLine(animal.Gestation);
                Console.WriteLine(animal.Respiration);


            }


        }
    }
}