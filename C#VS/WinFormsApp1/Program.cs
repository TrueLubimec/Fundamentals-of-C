namespace WinFormsApp1
{
    internal static class Program
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
            int[] anArray = { 1, 2, 4 };
            ref int Aref = ref anArray[0];
        }
        ////�������� ����� REF                                                          �������� ����� REF
        //static void Foo(ref int a) //����� ref ��������� �� ������ ,� �� ��������, �.�. �� ���������� � ������� ���� �������� �� ����������� � ������
        //{
        //    a = -5;
        //}
    }
}