public abstract class Pets
{
    public String TypePet { get; set; }
    public String Name { get; set; }
    public String sex { get; set; }
    public int age { get; set; }
    public String breed { get; set; }

    public String toString()
    {
        return "Котик или пёсель? - " + TypePet + '\n' +
                "Кличка - " + Name + '\n' +
                "Пол - " + sex + '\n' +
                "Возраст - " + age + '\n' +
                "Порода - " + breed + '\n';
    }

    public void showInfo()
    {
        Console.WriteLine(this);
    }

    public Pets()
    {
        this.TypePet = TypePet;
        this.Name = Name;
        this.sex = sex;
        this.age = age;
        this.breed = breed;
    }

    public String getTypePet()
    {
        return TypePet;
    }

    public void setTypePet(String typePet)
    {
        TypePet = typePet;
    }

    public String getName()
    {
        return Name;
    }

    public void setName(String name)
    {
        Name = name;
    }

    public String getSex()
    {
        return sex;
    }

    public void setSex(String sex)
    {
        this.sex = sex;
    }

    public int getAge()
    {
        return age;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public String getBreed()
    {
        return breed;
    }

    public void setBreed(String breed)
    {
        this.breed = breed;
    }

    public List<String> getInfoForPets(int count)
    {
        List<String> pets = new List<String>();
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Введите кличку домашнего питомца");
            string input1 = Console.ReadLine();
            pets.Add(input1);
        }
        return pets;
    }
}