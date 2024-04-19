namespace Algorytmy2
{
    public class Sortowanie(int[] cyfry)
    {
        public int[] _cyfry = cyfry;

        /**************************************
        * nazwa funkcji:       findLowest()
        * parametry wejściowe: Bierze wartosci z int[] _cyfry.
        * wartość zwracana:    int, najmniejsza liczba z arrayu
        * autor:               Radosław Stefański 3D
        *************************************/
        public int FindLowest()
        {
            int currentLowest = int.MaxValue;

            foreach (int cyfra in cyfry)
            {
                if (cyfra < currentLowest)
                    currentLowest = cyfra;
            }

            return currentLowest;
        }

        /**************************************
         * nazwa funkcji:       FindLowestAndExchange()
         * parametry wejściowe: Bierze wartosci z int[] _cyfry.
         * wartość zwracana:    int[]
         * autor:               Radosław Stefański 3D
        *************************************/
        public int[] FindLowestAndExchange()
        {
            int[] _cyfryClone = (int[])_cyfry.Clone();

            for (var i = 0; i < _cyfry.Length; i++)
            {
                if (_cyfryClone[i] == FindLowest())
                    _cyfryClone[i] = i;
            }

            return _cyfryClone;
        }

        /**************************************
        * nazwa funkcji:       FindHighest()
        * parametry wejściowe: Bierze wartosci z int[] _cyfry.
        * wartość zwracana:    int, najwieksza liczba z arrayu
        * autor:               Radosław Stefański 3D
        *************************************/
        public int FindHighest()
        {
            int currentHighest = int.MinValue;

            foreach (int cyfra in cyfry)
            {
                if (cyfra > currentHighest)
                    currentHighest = cyfra;
            }

            return currentHighest;
        }

        /**************************************
        * nazwa funkcji:       Sort()
        * parametry wejściowe: Bierze wartosci z int[] _cyfry.
        * wartość zwracana:    posortowany array.
        * autor:               Radosław Stefański 3D
        *************************************/
        public int[] Sort(int[] sortedarray)
        {
            for (int i = 0; i < _cyfry.Length - 1; i++)
            {
                if (sortedarray[i] < sortedarray[i + 1])
                {
                    int temp = sortedarray[i];
                    sortedarray[i] = sortedarray[i + 1];
                    sortedarray[i + 1] = temp;

                    i = -1;
                }
            }
            return sortedarray;
        }
    }
}
