namespace WinFormsApp1
{
    internal static class WinForm
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //// �������� ������������ �� ��������� NULL                                    �������� ������������ �� ��������� NULL

            //string str = null;
            //str ??= string.Empty; //����� �� ������ 8.0 � ���� (��� ����������)
            //Console.WriteLine($"The length of the string: {str.Length}");


            //int[] MyArray = {1,23,14,24};
            //MyArray ??= new int[0];
            //Console.WriteLine($"Amount: {MyArray.Length}");


            //// �������� ��������� NULL                                                    �������� ��������� NULL

            //int[] anArray = { };
            //Console.WriteLine($"Amount of elements: {anArray?.Length ?? 0}"); //������� ��������� �� NULL � ����������� ������ ����� NULL. ���� NULL - �� ������� 0.


            ////�������� ����� REF                                                          �������� ����� REF

            //int a = -2;
            //Foo(ref a);

            //� ����� ������� ����� ����� ��������� ��������� ��������� ����������.
            //int[] anArray = { 1, 2, 4 };
            //ref int Aref = ref anArray[0];


            int[] anArray = new int[5];
            Random random = new Random();
            for (int i = 0; i < anArray.Length; i++)
            {
                anArray[i] = random.Next(1, 10);
            }
            Array.Resize(ref anArray, anArray.Length - 4);
            for (int i = 0; i < anArray.Length; i++)
                Console.WriteLine(anArray[i]);

            int var1 = int.Parse(Console.ReadLine());
            int inserted = int.Parse(Console.ReadLine());
            Jopa(ref anArray, var1, inserted);
            for (int i = 0; i < anArray.Length; i++)
                Console.WriteLine(anArray[i]);
        }

        static ref int Jopa(ref int[] anArray, int var1, int inserted)
        {
            anArray[var1] = inserted;
            return ref anArray[var1];
        }
        static ref int Jopa(ref int[] anArray, string place, int inserted)
        {
            if (place == "end")
            {
                anArray[^1] = inserted;
                return ref anArray[^1];
            }
            else if (place == "start")
            {
                anArray[1] = inserted;
                return ref anArray[1];
            }
            return ref anArray[0];
        }
    }
        
        ////�������� ����� REF                                                          �������� ����� REF
        //static void Foo(ref int a) //����� ref ��������� �� ������ ,� �� ��������, �.�. �� ���������� � ������� ���� �������� �� ����������� � ������
        //{
        //    a = -5;
        //}
}