namespace HomeWork3_10_4; 

public class MyList<TItem> {

    private List<TItem> innerList = new List<TItem>();

    public void Add(TItem item) {
        innerList.Add(item);
    }

    public void Remove(TItem item) {
        innerList.Remove(item);
    }

    public void RemoveByIndex(int index) {
        innerList.RemoveAt(index);
    }

    public void ClearAll() {
        innerList.Clear();
    }

    //a[5] = 77
    public TItem this[int index] {
        get {
            return innerList[index];
        }
        set {
            innerList[index] = value;
        }
    }

    public int ListLength { 
        get {
            return innerList.Count;    
        } 
    }
}
