public class People
{
    public String Name { get; set; }
    public String sex { get; set; }
    public int age { get; set; }
    public String job { get; set; }
    public Boolean isMarried { get; set; }
    public String PartnerName { get; set; }
    public int countPet { get; set; }
    public String[] PetName { get; set; }
    public int countBrothers { get; set; }
    public String[] BrotherName { get; set; }
    public int countSisters { get; set; }
    public String[] SisterName { get; set; }
    public int countChildren { get; set; }
    public String[] ChildName { get; set; }

    public People()
    {
    }

    // public string toString()
    // {
    //     return "Имя - " + Name + '\n' +
    //             "Пол - " + sex + '\n' +
    //             "Возраст - " + age + '\n' +
    //             "Работа - '" + job + '\n' +
    //             "Женат или замужем? - " + isMarried + '\n' +
    //             "Как зовут жену/мужа? - " + PartnerName + '\n' +
    //             "Количество питомцев - " + countPet + '\n' +
    //             "Кличка(и) питомца(ев) - " + PetName + '\n' +
    //             "Количество братьев - " + countBrothers + '\n' +
    //             "Имена братьев" + BrotherName + '\n' +
    //             "Количество сестер" + countSisters + '\n' +
    //             "Имена сестер - " + SisterName + '\n' +
    //             "Количество детей - " + countChildren + '\n' +
    //             "Имена детей - " + ChildName + '\n';
    // }

    public void getPropertyValues()
    {
        Console.WriteLine("Имя - " + Name);
        Console.WriteLine("Пол - " + sex);
        Console.WriteLine("Возраст - " + age);
        Console.WriteLine("Работа - '" + job);
        Console.WriteLine("Женат или замужем? - " + isMarried);
        Console.WriteLine("Как зовут жену/мужа? - " + PartnerName);
        Console.WriteLine("Количество питомцев - " + countPet);
        Console.WriteLine("Кличка(и) питомца(ев) - " + PetName);
        Console.WriteLine("Количество братьев - " + countBrothers);
        Console.WriteLine("Имена братьев" + BrotherName);
        Console.WriteLine("Количество сестер" + countSisters);
        Console.WriteLine("Имена сестер - " + SisterName);
        Console.WriteLine("Количество детей - " + countChildren);
        Console.WriteLine("Имена детей - " + ChildName);
    }

    public People(String name, String sex, int age, String job, Boolean isMarried, int countPet, int countBrothers, int countSisters, int countChildren)
    {
        Name = name;
        this.sex = sex;
        this.age = age;
        this.job = job;
        this.isMarried = isMarried;
        this.countPet = countPet;
        this.countBrothers = countBrothers;
        this.countSisters = countSisters;
        this.countChildren = countChildren;
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

    public String getJob()
    {
        return job;
    }

    public void setJob(String job)
    {
        this.job = job;
    }

    // public Boolean isMarried() {
    //     return isMarried;
    // }

    public void setMarried(Boolean married)
    {
        isMarried = married;
    }

    public String getPartnerName()
    {
        return PartnerName;
    }

    public void setPartnerName(String partnerName)
    {
        PartnerName = partnerName;
    }

    public int getCountPet()
    {
        return countPet;
    }

    public void setCountPet(int countPet)
    {
        this.countPet = countPet;
    }

    public String[] getPetName()
    {
        return PetName;
    }

    public void setPetName(String[] petName)
    {
        PetName = petName;
    }

    public int getCountBrothers()
    {
        return countBrothers;
    }

    public void setCountBrothers(int countBrothers)
    {
        this.countBrothers = countBrothers;
    }

    public String[] getBrotherName()
    {
        return BrotherName;
    }

    public void setBrotherName(String[] brotherName)
    {
        BrotherName = brotherName;
    }

    public int getCountSisters()
    {
        return countSisters;
    }

    public void setCountSisters(int countSisters)
    {
        this.countSisters = countSisters;
    }

    public String[] getSisterName()
    {
        return SisterName;
    }

    public void setSisterName(String[] sisterName)
    {
        SisterName = sisterName;
    }

    public int getCountChildren()
    {
        return countChildren;
    }

    public void setCountChildren(int countChildren)
    {
        this.countChildren = countChildren;
    }

    public String[] getChildName()
    {
        return ChildName;
    }

    public void setChildName(String[] childName)
    {
        ChildName = childName;
    }
    /** Метод используется для получения информации от пользователя о человеке */
    public List<String> getInfoForRelatives(int count)
    {
        {
            List<String> relatives = new List<String>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите ФИО человека:");
                string input1 = Console.ReadLine();
                relatives.Add(input1);
            }
            return relatives;
        }
    }

    public string getInfoForPartner(Boolean isMarried)
    {
        if (isMarried == true)
        {
            Console.WriteLine("Введите ФИО жены/мужа:");
            string input1 = Console.ReadLine();
            String wifeOrHusb = input1;
            return wifeOrHusb;
        }
        else
        {
            String wifeOrHusb = "холост";
            return wifeOrHusb;
        }
    }
}
