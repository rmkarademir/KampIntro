using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T türünde bir class. T herhangi bir tür olabilir. class örneklendiğinde (new yapıldığında) verilen türe göre T değişir.
    {
        T[] items; // T türünde items isimli bir array tanımlandı.
        public MyList() // constructor MyList classı new yapıldığında ilk çalışacak kısım
        {
            items = new T[0]; // items isimli arraye yeni bir adress verildi. heapte yeni bir alan açıldı. eski veriler silindi.
        }
        public void Add(T item)
        {
            T[] tempArray = items; // items içindeki veriler T türündeki tempArray(geçici array) aktarıldı. new yapıldığında itemsdaki verileri kaybetmemek için.
            items = new T[tempArray.Length + 1]; // items eleman sayısını 1 artırmak için, tempArray eleman sayısını bir arttırıp bellekte yeni bir items alanı oluşturuldu. 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // tempArray her elemanı döngü ile items aktarıldı.
            }
            items[items.Length - 1] = item; // items son elemanına kullanıcının vereceği item değeri eklendi.
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }    
}
