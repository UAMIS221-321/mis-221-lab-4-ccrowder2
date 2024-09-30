// Start Main

Menu();

// End Main

static void Pause(){
    System.Console.WriteLine("Press any key to continue:");
    Console.ReadKey();
}

static void Menu(){
    Console.Clear();
    System.Console.WriteLine("Please choose a menu option:\n1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
    string userChoice = Console.ReadLine();

    while(userChoice != "4"){
        Console.Clear();

        switch (userChoice) {
            case "1":
                Console.Clear();
                PlainPizza();
                Pause();
                break;
            case "2":
               Console.Clear();
               CheesePizza();
               Pause();
                break;
            case "3":
                Console.Clear();
                PepPizza();
                Pause();
                break;
            case "4":
                break;
            default:
                System.Console.WriteLine("Invalid menu option, please try again");
                break;
        }
        Console.Clear();

        System.Console.WriteLine("Please choose a menu option:\n1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
        userChoice = Console.ReadLine();
    }

}

static void PlainPizza(){
    Random rnd = new Random();
    int size = rnd.Next(8,13);
    int num2 = size;

    for(int i = size;i>0;i--){
        for(int j = num2;j>0;j--){
            System.Console.Write("*");
        }
        num2--;
        System.Console.WriteLine();
    }
}

static void CheesePizza(){
    Random rnd = new Random();
    int size = rnd.Next(8,13);
    int num2 = size-3;
    int newSize = size-1;
    for(int i =size;i>0;i--){
        System.Console.Write("*");
    }
    System.Console.WriteLine();
    for(int i = newSize;i>0;i--){
        System.Console.Write("*");
        for(int j = num2;j>0;j--){
            System.Console.Write("#");
        }
        num2--;
        if(i!=1){
        Console.Write("*");
        }
        System.Console.WriteLine();
    }
}

static void PepPizza(){
    Random rnd2 = new Random();
    Random rnd = new Random();
    int size = rnd.Next(8,13);
    int num2 = size-3;
    int newSize = size-1;
    for(int i =size;i>0;i--){
        System.Console.Write("*");
    }
    System.Console.WriteLine();
    for(int i = newSize;i>0;i--){
        System.Console.Write("*");
        for(int j = num2;j>0;j--){
            int pep = rnd.Next(0,num2+1);
            // [] counts as two characters so this is what I did to fix the length issue
            if(pep == j && j>1){
                System.Console.Write("[]");
                j--;
            } else {
            System.Console.Write("#");
            }
        }
        num2--;
        if(i!=1){
        Console.Write("*");
        }
        System.Console.WriteLine();
    }
}