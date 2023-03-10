namespace GenericsIntro;

public class MyDictionary<TKey,TValue>
{
    private TKey[] keys;
    private TValue[] values;

    public MyDictionary()
    {
        keys = new TKey[0];
        values = new TValue[0];
    }

    public void Add(TKey key, TValue value)
    {
        TKey[] tempArray1 = keys;
        TValue[] tempArray2 = values;

        keys = new TKey[keys.Length + 1];
        values = new TValue[values.Length + 1];

        for (int i = 0; i < tempArray1.Length; i++)
        {
            keys[i] = tempArray1[i];
        }
        for (int i = 0; i < tempArray2.Length; i++)
        {
            values[i] = tempArray2[i];
        }

        keys[keys.Length - 1] = key;
        values[values.Length - 1] = value;
    }

    public int KeyCount
    {
        get { return keys.Length; }
    }
    public int ValueCount
    {
        get { return values.Length; }
    }


}