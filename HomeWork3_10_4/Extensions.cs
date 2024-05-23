namespace HomeWork3_10_4;

public static class Extensions {

    public static T[] GetArray<T>(this MyList<T> list) {
        T[] arr = new T[list.ListLength];
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = list[i];
        }
        return arr;
    }

}
