# BinarySearchTreeProjesi

**[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.**

*Örnek: root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.*

[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] 

                    7                       * root
                5                           1. Aşama  : 5, 7'den küçük bu yüzden 7'nin sol alta gelir.
            1                               2. Aşama  : 1, 5'ten küçük bu yüzden 5'in sol alta gelir
        
---       
                     7          
                5          8                3. Aşama  : 8, 7'den büyük bu yüzden 7'nin sağ alta gelir.
            1       3                       4. Aşama  : 3, 5'ten küçük ve 1'den büyük bu yüzden 5'in sağ altına gelir.
                       6                    5. Aşama  : 6, 7'den küçük ve 5'ten büyük bu yüzden 3'ün sağ altına gelir.
        0                                   6. Aşama  : 0, 1'den küçük bu yüzden 1'in sol altına gelir.
---  
                      7
                5            8
                     3               9      7. Aşama  : 9, 7'den büyük ve 8'den büyük bu yüzden 8'in sağ altına gelir.
            1     4     6                   8. Aşama  : 4, 5'ten küçük ve 3'ten büyük ama 6'dan küçük bu yüzden 6'nın sol altına gelir.
        0        2                          9. Aşama  : 2, 3'ten küçük bu yüzden 3'ün sol altına gelir.
