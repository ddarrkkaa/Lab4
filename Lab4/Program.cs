namespace Lab4
{
    class App4
    {
        public static void Main()
        {
            Console.WriteLine("if you want to pick some clothes enter the num \n" +
                              "1 for jacket\n" +
                              "2 for shirt\n" +
                              "3 for shoes\n" +
                              "4 for pants\n");
            int num = Int32.Parse(Console.ReadLine());

            Clothing clothing = new Clothing();
            clothing.GetDressed(num);
        }
    }
}


