namespace Algorytmy2
{
    public class Sortowanie(int[] cyfry)
    {
        public int[] _cyfry = cyfry;

        /**************************************
        * nazwa funkcji:       Sort()
        * parametry wejściowe: Bierze wartosci z int[] _cyfry.
        * wartość zwracana:    int, najmniejsza liczba z arrayu
        * autor:               Radosław Stefański 3D
        *************************************/
        public int Sort()
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
                if (_cyfryClone[i] == Sort())
                    _cyfryClone[i] = i;
            }

            return _cyfryClone;
        }
    }
}
