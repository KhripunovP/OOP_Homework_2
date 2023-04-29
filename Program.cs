public class FamilyTree
{
    public static void Main(String[] args)
    {
        People father = new People("Иван_Васильевич_Смирнов", "мужской", 45, "Юрист", true, 1, 0, 0, 2);
        People mother = new People("Анна_Романовна_Смирнова", "женский", 38, "Врач", true, 1, 1, 0, 2);
        People child1 = new People("Андрей_Иванович_Смирнов", "мужской", 14, "Школьник", false, 2, 0, 1, 0);
        People child2 = new People("Мария_Ивановна_Смирнова", "женский", 10, "Школьница", false, 1, 1, 0, 0);
        People uncle = new People("Станислав_Романович_Анисимов", "мужской", 23, "Инженер", false, 0, 0, 1, 0);
        Pets cat1 = new Cats("Кот", "Петруша", "мальчик", 5, "двор-кот");
        Pets dog1 = new Dogs("Пёсель", "Патрик", "мальчик", 10, "Чау-чау");
        List<People> familyTree = new List<People>();
        List<Pets> petsTree = new List<Pets>();

        familyTree.Add(father);
        familyTree.Add(mother);
        familyTree.Add(child1);
        familyTree.Add(child2);
        familyTree.Add(uncle);
        petsTree.Add(cat1);
        petsTree.Add(dog1);

        /** Получение от пользователя информации о конкретном человеке и поиск в дереве совпадений */
        Console.WriteLine("Добавим информацию о жене");
        father.setPartnerName(father.getInfoForPartner(father.isMarried));
        int count = 0;
        for (int i = 0; i < familyTree.Count; i++)
        {
            if (familyTree[i].getName() == father.getPartnerName())
            {
                Console.WriteLine("Подробнее о ней из информации семейного дерева");
                familyTree[i].getPropertyValues();
                count += 1;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("В семейном дереве о ней пока нет информации");
        }
      
        /** Вывод в консоль имеющейся информации о конкретном человеке */
        Console.WriteLine("Дополненная инфа об отце");
        father.getPropertyValues();
    }
}

