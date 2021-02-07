using System;
namespace GenericsIntro
{
    class MyList<T>//Bana bir tip ver ben aşağı ona göre yapılandıracağım.
    {

        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
