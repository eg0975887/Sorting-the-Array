namespace name2
{
    public class LabArray
    {
        int[] ArrayOf10 = new int[10];

        public void fillArray()
        {
            for (int i = 0; i < ArrayOf10.Length; i++)
            {
                ArrayOf10[i] = i + 1;
            }
        }
        public void printArray()
        {
            for (int i = 0; i < ArrayOf10.Length; i++)
            {
                System.Console.Write(ArrayOf10[i] + " ");
            }
        }
    }

}
