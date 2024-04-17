namespace TestTask
{
    static class Sorting
    {
        static public void Sort(Pallets[] Array)
        {
            bool flag = true;
            Pallets a;
            while (flag)
            {
                flag = false;
                for (int i = 1; i < Array.Length; i++)
                {
                    if (Array[i].getExpirationDate() < Array[i - 1].getExpirationDate())
                    {
                        a = Array[i - 1];
                        Array[i - 1] = Array[i];
                        Array[i] = a;
                        flag = true;
                    }
                    if (Array[i].getExpirationDate() == Array[i - 1].getExpirationDate() && Array[i].getWeight() < Array[i - 1].getWeight())
                    {
                        a = Array[i - 1];
                        Array[i - 1] = Array[i];
                        Array[i] = a;
                        flag = true;
                    }
                }
            }
        }

        static public void SortEnd(Pallets[] Array)
        {
            bool flag = true;
            Pallets a;
            while (flag)
            {
                flag = false;
                for (int i = 1; i < Array.Length; i++)
                {
                    if (Array[i].getExpirationDate() < Array[i - 1].getExpirationDate())
                    {
                        a = Array[i - 1];
                        Array[i - 1] = Array[i];
                        Array[i] = a;
                        flag = true;
                    }
                }
            }
            flag = true;
            while (flag)
            {
                flag = false;
                for (int i = Array.Length - 2; i < Array.Length; i++)
                {
                    if (Array[i].CalculatingVolume() < Array[i - 1].CalculatingVolume())
                    {
                        a = Array[i - 1];
                        Array[i - 1] = Array[i];
                        Array[i] = a;
                        flag = true;
                    }
                }
            }
        }
    }
}
