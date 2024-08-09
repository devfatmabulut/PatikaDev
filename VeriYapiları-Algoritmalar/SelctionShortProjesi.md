# [SELECTION SORT PROJECT](https://academy.patika.dev/tr/courses/veri-yapilari-ve-algoritmalar/insertion-sort-proje)

## ÖDEV

### 1.KISIM
**[22,27,16,2,18,6] -> Insertion Sort**

* Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.
    [22,27,16,2,18,6] **Dizi**
    [2,27,16,22,18,6] 22 ile 2 yer değişir -> **n**
    [2,6,16,22,18,27] 2 artık sabit. 27 ile 6 yer değişir ->**n-1**
    [2,6,16,22,18,27] 2 ve 6 artık sabit. Sıradaki sayı 16 bu yüzden bir şey yapmıyoruz. **n-2**
    [2,6,16,18,22,27] 2,6 ve 16 artık sabit. 22 ve 18 yer değiştirir **n-3**
    [2,6,16,18,22,27] Sıradaki sayı 22 bu yüzden bir işlem yapmıyoruz ve Sıralamamız artık 1'e eşitlendi. **1**

* Big-O gösterimini yazınız. -> **O(n)**

**Time Complexity: Dizi sıralandıktan sonra 18 sayısı aşağıdaki case'lerden hangisinin kapsamına girer? Yazınız**

1. Average case: Aradığımız sayının ortada olması
2. Worst case: Aradığımız sayının sonda olması
3. Best case: Aradığımız sayının dizinin en başında olması.

**CEVAP :**  *1. Average Vase*

### 2.KISIM
**[7,3,5,8,2,9,4,15,6]** dizisinin Selection Sort'a göre ilk 4 adımını yazınız.
1. Adım: [2,3,5,8,7,9,4,15,6]
2. Adım: [2,3,5,8,7,9,4,15,6]
3. Adım : [2,3,4,8,7,9,5,15,6]
4. Adım : [2,3,4,5,7,9,8,15,6]