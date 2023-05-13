namespace NormalList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            for(int i = 0; i < 30; i++)
            {
                list.PushBack(i);
            }

            list.DisplayInfo();
        }
    }
}