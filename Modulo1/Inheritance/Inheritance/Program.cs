
using Inheritance;
using static Inheritance.Animals;

Animals dog = new Animals.Dog
{
    Name = "Fuffi",
    Age = 7,
};
dog.Speak();

Animals cat = new Animals.Cat
{
    Name = "Lala",
    Age = 8,
};
cat.Speak();

Animals cow = new Animals.Cow
{
    Name = "Mumi",
    Age = 9,
};
cow.Speak();

Animals leon = new Animals.Leon
{
    Name = "Rocco",
    Age = 10,
};
leon.Speak();